using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BetaTesters.Infrastructure.Constants.DataConstants;

namespace BetaTesters.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Transactions = new HashSet<Transaction>();
            SentPayments = new HashSet<Payment>();
            ReceivedPayments = new HashSet<Payment>();
            Credits = new HashSet<UsersCredits>();
            Applications = new HashSet<CandidateApplication>();
        }

        [Required]
        [MaxLength(ApplicationUserFirstNameMaxLength)]
        [PersonalData]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(ApplicationUserLastNameMaxLength)]
        [PersonalData]
        public string LastName { get; set; } = string.Empty;

        [PersonalData]
        public int Age { get; set; }

        public decimal Balance { get; set; }

        //Application to be added

        public IEnumerable<Transaction> Transactions { get; set; }

        [InverseProperty(nameof(Payment.Sender))]
        public IEnumerable<Payment> SentPayments { get; set; }

        [InverseProperty(nameof(Payment.Receiver))]
        public IEnumerable<Payment> ReceivedPayments { get; set; }

        public IEnumerable<UsersCredits> Credits { get; set; }

        public IEnumerable<CandidateApplication> Applications { get; set; }
    }
}
