using BetaTesters.Core.Models.ApplicationUserModels;
using System.ComponentModel.DataAnnotations;
using static BetaTesters.Core.Constants.MessageConstants;
using static BetaTesters.Infrastructure.Constants.DataConstants;

namespace BetaTesters.Core.Models.Payment
{
    public class PaymentServiceModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [Range(PaymentAmountMinValue, PaymentAmountMaxValue)]
        public decimal Money { get; set; }

        public string ReceiverId { get; set; } = string.Empty;

        public ApplicationUserViewModel? Receiver { get; set; } 
    }
}
