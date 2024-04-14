using BetaTesters.Core.Enums;
using BetaTesters.Core.Models.CandidateApplication;
using BetaTesters.Core.Models.Task;

namespace BetaTesters.Core.Contracts
{
    public interface ITaskService
    {
        Task<TaskQueryServiceModel> AllByProgramIdAsync(
            string programId,
            string? category,
            TaskSorting taskSorting = TaskSorting.Available,
            int currentPage = 1,
            int tasksPerPage = 1
            );

        Task<IEnumerable<TaskCategoryServiceModel>> AllCategoriesAsync();

        Task<IEnumerable<string>> AllCategoriesNameAsync();

        Task<int> GetAllTasksCountForCurrentProgramAsync(string programId);

        Task CreateAsync(TaskFormModel model, string creatorId, DateTime? assignDate);

        Task<bool> CategoryExistsAsync(int categoryId);

        Task<IEnumerable<TaskWaitListViewModel>> TaskWaitListByProgramIdAsync(string programId);

        Task<TaskWaitListViewModel> TaskWaitListViewModelInspectByIdAsync(string taskId);

        Task ApproveTaskAsync(string taskId);

        Task RejectTaskAsync(string taskId);
    }
}
