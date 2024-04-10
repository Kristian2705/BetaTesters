using System.ComponentModel.DataAnnotations;
using static BetaTesters.Infrastructure.Constants.DataConstants;

namespace BetaTesters.Infrastructure.Data.Models
{
    public class BetaProgram
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(BetaProgramNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(BetaProgramDescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        public IEnumerable<Task> Tasks { get; set; } = new HashSet<Task>();

        public IEnumerable<CandidateApplication> Applications { get; set; } = new HashSet<CandidateApplication>();

        public IEnumerable<ApplicationUser> Users { get; set; } = new HashSet<ApplicationUser>();
    }
}
