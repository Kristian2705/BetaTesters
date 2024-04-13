using BetaTesters.Infrastructure.ValidationAttributes;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BetaTesters.Infrastructure.Constants.DataConstants;

namespace BetaTesters.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [Required]
        [MaxLength(ApplicationUserFirstNameMaxLength)]
        [PersonalData]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(ApplicationUserLastNameMaxLength)]
        [PersonalData]
        public string LastName { get; set; } = string.Empty;

        [PersonalData]
        [MustBeAdult]
        public int Age { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }

        public Guid? BetaProgramId { get; set; }

        [ForeignKey(nameof(BetaProgramId))]
        public BetaProgram? BetaProgram { get; set; }

        public IEnumerable<Transaction> Transactions { get; set; } = new HashSet<Transaction>();

        [InverseProperty(nameof(Payment.Sender))]
        public IEnumerable<Payment> SentPayments { get; set; } = new HashSet<Payment>();

        [InverseProperty(nameof(Payment.Receiver))]
        public IEnumerable<Payment> ReceivedPayments { get; set; } = new HashSet<Payment>();

        public IEnumerable<CandidateApplication> Applications { get; set; } = new HashSet<CandidateApplication>();

        [InverseProperty(nameof(Task.Contractor))]
        public IEnumerable<Task> Tasks { get; set; } = new HashSet<Task>();

        [InverseProperty(nameof(Task.Creator))]
        public IEnumerable<Task> CreatedTasks { get; set; } = new HashSet<Task>();
    }
}
