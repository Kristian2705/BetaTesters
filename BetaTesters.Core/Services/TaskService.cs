using BetaTesters.Core.Contracts;
using BetaTesters.Core.Enums;
using BetaTesters.Core.Models.Task;
using BetaTesters.Infrastructure.Data.Common;
using BetaTesters.Infrastructure.Data.Enums;
using BetaTesters.Infrastructure.Constants;

namespace BetaTesters.Core.Services
{
    using BetaTesters.Core.Extensions;
    using Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualBasic;
    using System;
    using System.Collections.Generic;

    public class TaskService : ITaskService
    {
        private readonly IRepository repository;
        private readonly IApplicationUserService applicationUserService;

        public TaskService(IRepository _repository,
            IApplicationUserService _applicationUserService)
        {
            repository = _repository;
            applicationUserService = _applicationUserService;
        }

        public async Task<TaskQueryServiceModel> AllByProgramIdAsync(string programId, string? category, TaskSorting taskSorting = TaskSorting.Available, int currentPage = 1, int tasksPerPage = 1)
        {
            var tasksToShow = repository.AllReadOnly<Task>()
                .Where(t => t.Approval == Approval.Accepted && t.ProgramId == Guid.Parse(programId));

            if (category != null)
            {
                tasksToShow = tasksToShow
                    .Where(t => t.Category.CategoryName == category);
            }

            tasksToShow = taskSorting switch
            {
                TaskSorting.Available => tasksToShow
                    .Where(t => t.State == TaskState.Available),
                TaskSorting.InProgress => tasksToShow
                    .Where(t => t.State == TaskState.InProgress),
                TaskSorting.Completed => tasksToShow
                    .Where(t => t.State == TaskState.Completed),
                TaskSorting.DateAscending => tasksToShow
                    .OrderBy(t => t.AssignDate),
                TaskSorting.DateDescending => tasksToShow
                    .OrderByDescending(t => t.AssignDate),
                TaskSorting.RewardAscending => tasksToShow
                    .OrderBy(t => t.Reward),
                 _ => tasksToShow
                    .OrderByDescending(t => t.Reward)       
            };

            var tasks = await tasksToShow
                .Skip((currentPage - 1) * tasksPerPage)
                .Take(tasksPerPage)
                .ProjectToTaskServiceModel()
                .ToListAsync();

            int totalHouses = await tasksToShow.CountAsync();

            return new TaskQueryServiceModel()
            {
                Tasks = tasks,
                TotalTasksCount = totalHouses
            };
        }

        public async Task<IEnumerable<TaskCategoryServiceModel>> AllCategoriesAsync()
        {
            return await repository.AllReadOnly<Category>()
                .Select(c => new TaskCategoryServiceModel()
                {
                    Id = c.Id,
                    Name = c.CategoryName,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> AllCategoriesNameAsync()
        {
            return await repository.AllReadOnly<Category>()
                .Select(c => c.CategoryName)
                .Distinct()
                .ToListAsync();
        }

        public async System.Threading.Tasks.Task ApproveTaskAsync(string taskId)
        {
            var task = await repository.GetByIdAsync<Task>(Guid.Parse(taskId));

            task.AssignDate = DateTime.Now;

            task.Approval = Approval.Accepted;

            task.State = TaskState.Available;

            await repository.SaveChangesAsync();
        }

        public async Task<bool> CategoryExistsAsync(int categoryId)
        {
            return await repository.AllReadOnly<Category>()
                .AnyAsync(c => c.Id == categoryId);
        }

        public async System.Threading.Tasks.Task CreateAsync(TaskFormModel model, string creatorId, DateTime? assignDate)
        {
            var task = new Task()
            {
                Name = model.Name,
                Description = model.Description,
                Approval = model.Approval,
                CategoryId = model.CategoryId,
                Reward = model.Reward,
                AssignDate = assignDate,
                State = model.TaskState,
                CreatorId = Guid.Parse(creatorId),
                ProgramId = Guid.Parse(model.ProgramId)
            };

            await repository.AddAsync(task);
            await repository.SaveChangesAsync();
        }

        public async Task<int> GetAllTasksCountForCurrentProgramAsync(string programId)
        {
            return await repository.AllReadOnly<Task>()
                .Where(t => t.ProgramId == Guid.Parse(programId))
                .CountAsync();
        }

        public async System.Threading.Tasks.Task RejectTaskAsync(string taskId)
        {
            await repository.DeleteAsync<Task>(Guid.Parse(taskId));

            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<TaskInspectViewModel>> TaskWaitListByProgramIdAsync(string programId)
        {
            return await repository.AllReadOnly<Task>()
                .Where(t => t.ProgramId == Guid.Parse(programId) && t.State == TaskState.ToBeApproved)
                .Select(t => new TaskInspectViewModel()
                {
                    Id = t.Id,
                    Name = t.Name,
                    Description = t.Description,
                    Reward = t.Reward,
                    Creator = t.Creator
                })
                .ToListAsync();
        }

        public async Task<TaskInspectViewModel> TaskInspectViewModelByIdAsync(string taskId)
        {
            return await repository.AllReadOnly<Task>()
                .Where(t => t.Id == Guid.Parse(taskId))
                .Select(t => new TaskInspectViewModel()
                {
                    Id = t.Id,
                    Name = t.Name,
                    Description = t.Description,
                    Creator = t.Creator,
                    Approval = t.Approval,
                    State = t.State,
                    BetaProgramId = t.ProgramId,
                    ContractorId = t.ContractorId.ToString(),
                    Reward = t.Reward
                })
                .FirstAsync();
        }

        public async System.Threading.Tasks.Task TakeTaskAsync(string taskId, string userId)
        {
            var task = await repository.GetByIdAsync<Task>(Guid.Parse(taskId));

            task.State = TaskState.InProgress;

            task.ContractorId = Guid.Parse(userId);

            await repository.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task CompleteTaskAsync(string taskId)
        {
            var task = await repository.GetByIdAsync<Task>(Guid.Parse(taskId));

            task.State = TaskState.Completed;

            task.FinishDate = DateTime.Now;

            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<TaskServiceModel>> GetTasksByUserIdAndProgramId(string userId, string programId)
        {
            return await repository.AllReadOnly<Task>()
                .Where(t => t.ContractorId == Guid.Parse(userId) && t.ProgramId == Guid.Parse(programId))
                .Select(t => new TaskServiceModel()
                {
                    Id = t.Id,
                    Name = t.Name,
                    Description = t.Description,
                    AssignDate = t.AssignDate.Value.ToString(DataConstants.DateFormat),
                    FinishDate = t.FinishDate.Value.ToString(DataConstants.DateFormat),
                    ContractorId = t.ContractorId.ToString(),
                    Reward = t.Reward,
                    State = t.State
                })
                .ToListAsync();
        }
    }
}
