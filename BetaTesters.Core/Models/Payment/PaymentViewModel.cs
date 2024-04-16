using BetaTesters.Infrastructure.Data.Models;

namespace BetaTesters.Core.Models.Payment
{
    public class PaymentViewModel
    {
        public ApplicationUser Receiver { get; set; } = null!;

        public decimal Amount { get; set; }
    }
}
