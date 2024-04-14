namespace BetaTesters.Core.Models.Task
{
    public class TaskQueryServiceModel
    {
        public int TotalTasksCount { get; set; }

        public IEnumerable<TaskServiceModel> Tasks { get; set; } = new List<TaskServiceModel>();
    }
}
