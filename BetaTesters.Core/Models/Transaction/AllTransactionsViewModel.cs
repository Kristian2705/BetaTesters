using BetaTesters.Infrastructure.Data.Enums;
using BetaTesters.Infrastructure.Data.Models;

namespace BetaTesters.Core.Models.Transaction
{
    public class AllTransactionsViewModel
    {
        public ApplicationUser User { get; set; } = null!;

        public decimal Money { get; set; }

        public TransactionType Type { get; set; }
    }
}
