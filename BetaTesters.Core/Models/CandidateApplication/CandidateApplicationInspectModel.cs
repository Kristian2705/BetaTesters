using BetaTesters.Infrastructure.Data.Models;

namespace BetaTesters.Core.Models.CandidateApplication
{
    public class CandidateApplicationInspectModel
    {
        public Guid Id { get; set; }

        public ApplicationUser Candidate { get; set; } = null!;

        public string Motivation { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public Guid BetaProgramId { get; set; }
    }
}
