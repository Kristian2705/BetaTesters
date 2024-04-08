using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BetaTesters.Infrastructure.Data.Models
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid SenderId { get; set; }

        [ForeignKey(nameof(SenderId))]
        public ApplicationUser Sender { get; set; } = null!;

        [Required]
        public Guid ReceiverId { get; set; }

        [ForeignKey(nameof(ReceiverId))]
        public ApplicationUser Receiver { get; set; } = null!;

        [Required]
        [Column("decimal(18,2)")]
        public decimal Money { get; set; }
    }
}
