using BetaTesters.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using static BetaTesters.Core.Constants.MessageConstants;
using static BetaTesters.Infrastructure.Constants.DataConstants;

namespace BetaTesters.Core.Models.Transaction
{
    public class TransactionServiceModel
    {
        public string UserId { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public TransactionType Type { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Range(TransactionAmountMinValue, TransactionAmountMaxValue)]
        public decimal Money { get; set; }
    }
}
