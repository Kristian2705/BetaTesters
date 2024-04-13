using BetaTesters.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BetaTesters.Infrastructure.Constants.DataConstants;

namespace BetaTesters.Infrastructure.Data.Models
{
    public class CandidateApplication
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(CandidateApplicationMotivationMaxLength)]
        public string Motivation { get; set; } = string.Empty;

        [Required]
        public Guid CandidateId { get; set; }

        [ForeignKey(nameof(CandidateId))]
        public ApplicationUser Candidate { get; set; } = null!;

        [Required]
        [MaxLength(PhoneNumberLength)]
        [MinLength(PhoneNumberLength)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public Guid BetaProgramId { get; set; }

        [ForeignKey(nameof(BetaProgramId))]
        public BetaProgram BetaProgram { get; set; } = null!;

        public Approval Approval { get; set; }
    }
}
