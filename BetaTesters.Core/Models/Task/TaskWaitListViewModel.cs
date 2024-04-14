using BetaTesters.Infrastructure.Data.Enums;
using BetaTesters.Infrastructure.Data.Models;

namespace BetaTesters.Core.Models.Task
{
    public class TaskWaitListViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Reward {  get; set; }

        public Approval Approval { get; set; }

        public Guid? BetaProgramId { get; set; }

        public ApplicationUser Creator { get; set; } = null!;
    }
}
