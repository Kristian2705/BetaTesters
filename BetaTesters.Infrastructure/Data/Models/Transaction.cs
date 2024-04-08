using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetaTesters.Infrastructure.Data.Enums;

namespace BetaTesters.Infrastructure.Data.Models
{
    public class Transaction
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
        public TransactionType Type { get; set; }
        public decimal Money { get; set; }
    }
}
