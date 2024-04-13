using System.ComponentModel.DataAnnotations;
using static BetaTesters.Infrastructure.Constants.DataConstants;
using static BetaTesters.Core.Constants.MessageConstants;

namespace BetaTesters.Core.Models.BetaProgram
{
    public class BetaProgramFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(BetaProgramNameMaxLength,
            MinimumLength = BetaProgramNameMinLength,
            ErrorMessage = LengthMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(BetaProgramDescriptionMaxLength,
            MinimumLength = BetaProgramDescriptionMinLength,
            ErrorMessage = LengthMessage)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
