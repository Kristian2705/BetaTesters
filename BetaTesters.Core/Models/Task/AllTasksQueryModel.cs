using BetaTesters.Core.Enums;
using BetaTesters.Infrastructure.Data.Enums;

namespace BetaTesters.Core.Models.Task
{
    public class AllTasksQueryModel
    {
        public const int TasksPerPage = 3;

        public int CurrentPage { get; init; } = 1;

        public string Name { get; set; } = string.Empty;

        public TaskSorting TaskSorting {  get; set; }

        public TaskState TaskState { get; set; }

        public int TotalTasksCount { get; set; }

        public string BetaProgramId { get; set; } = string.Empty;

        public string Category { get; set; } = null!;

        public IEnumerable<string> Categories { get; set; } = null!;

        public IEnumerable<TaskServiceModel> Tasks { get; set; } = new List<TaskServiceModel>();

    }
}
