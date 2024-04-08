using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BetaTesters.Infrastructure.Data.Models
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        [ForeignKey(nameof(SenderId))]
        public ApplicationUser Sender { get; set; } = null!;
        public Guid ReceiverId { get; set; }
        [ForeignKey(nameof(ReceiverId))]
        public ApplicationUser Receiver { get; set; } = null!;
        public decimal Money { get; set; }
    }
}
