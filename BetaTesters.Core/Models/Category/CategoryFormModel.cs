using static BetaTesters.Infrastructure.Constants.DataConstants;
using static BetaTesters.Core.Constants.MessageConstants;
using System.ComponentModel.DataAnnotations;

namespace BetaTesters.Core.Models.Category
{
    public class CategoryFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(CategoryNameMaxLength, 
            MinimumLength = CategoryNameMinLength,
            ErrorMessage = LengthMessage)]
        public string Name { get; set; } = string.Empty;
    }
}
