using BetaTesters.Core.Models.BetaProgram.Owner;

namespace BetaTesters.Core.Models.BetaProgram
{
    public class BetaProgramDetailsServiceModel : BetaProgramServiceModel
    {
        public int TotalTasksCompleted { get; set; }

        public int TotalParticipants { get; set; }

        public OwnerServiceModel Owner { get; set; } = null!;
    }
}
