using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BetaTesters.Infrastructure.Constants.DataConstants;

namespace BetaTesters.Infrastructure.Data.Models
{
    [Comment("This is the application of the candidates for the desired program")]
    public class CandidateApplication
    {
        [Key]
        [Comment("Candidate's application identifier")]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(CandidateApplicationMotivationMaxLength)]
        [Comment("The motivation of the candidate")]
        public string Motivation { get; set; } = string.Empty;
        [Required]
        [Comment("Candidate's identifier")]
        public Guid CandidateId { get; set; }
        [ForeignKey(nameof(CandidateId))]
        public ApplicationUser Candidate { get; set; } = null!;
        [Required]
        [Comment("Candidate's phone number")]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        [Comment("Candidate's age (they must be 18 or more)")]
        public int Age { get; set; }
        [Comment("Flag variable which checks whether the application has been reviewed")]
        public bool IsReviewed { get; set; }
        [Comment("Flag variable which checks whether the application has been approved or rejected")]
        public bool IsApproved { get; set; }
    }
}
