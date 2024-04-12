using BetaTesters.Infrastructure.Data.Enums;

namespace BetaTesters.Core.Models.CandidateApplication
{
    public class CandidateApplicationViewModel
    {
        public Guid Id { get; set; }

        public string Motivation { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string BetaProgramId { get; set; } = string.Empty;

        public Approval Approval { get; set; }
    }
}
