using System.ComponentModel.DataAnnotations;
using static BetaTesters.Infrastructure.Constants.DataConstants;
using static BetaTesters.Core.Constants.MessageConstants;

namespace BetaTesters.Core.Models
{
    public class CandidateApplicationFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(CandidateApplicationMotivationMaxLength, 
            MinimumLength = CandidateApplicationMotivationMinLength,
            ErrorMessage = LengthMessage)]
        public string Motivation { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(PhoneNumberLength,
            MinimumLength = PhoneNumberLength,
            ErrorMessage = PhoneMessage)]
        [Display(Name = "Phone number")]
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
