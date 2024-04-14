using BetaTesters.Core.Models.Task;
using static BetaTesters.Infrastructure.Constants.DataConstants;

namespace BetaTesters.Core.Extensions
{
    using BetaTesters.Infrastructure.Data.Models;
    public static class IQueryableTaskExtension
    {
        public static IQueryable<TaskServiceModel> ProjectToTaskServiceModel(this IQueryable<Task> tasks)
        {
            return tasks
                .Select(t => new TaskServiceModel()
                {
                    Id = t.Id,
                    Name = t.Name,
                    Description = t.Description,
                    AssignDate = t.AssignDate.Value.ToString(DateFormat),
                    FinishDate = t.FinishDate.Value.ToString(DateFormat),
                    ContractorId = t.ContractorId.ToString(),
                    Reward = t.Reward,
                    State = t.State,
                });
        }
    }
}
