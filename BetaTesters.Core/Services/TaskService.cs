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

        public TaskService(IRepository _repository)
        {
            repository = _repository;
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

        public async Task<int> GetAllTasksCountForCurrentProgram(string programId)
        {
            return await repository.AllReadOnly<Task>()
                .Where(t => t.ProgramId == Guid.Parse(programId))
                .CountAsync();
        }
    }
}
