using BetaTesters.Core.Contracts;
using BetaTesters.Core.Enums;
using BetaTesters.Core.Models.Task;
using BetaTesters.Infrastructure.Data.Common;
using BetaTesters.Infrastructure.Data.Enums;

namespace BetaTesters.Core.Services
{
    using BetaTesters.Core.Extensions;
    using Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
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

        public async Task<int> GetAllTasksCountForCurrentProgram(string programId)
        {
            return await repository.AllReadOnly<Task>()
                .Where(t => t.ProgramId == Guid.Parse(programId))
                .CountAsync();
        }
    }
}
