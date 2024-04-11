using System.ComponentModel.DataAnnotations;
using static BetaTesters.Core.Constants.MessageConstants;
using static BetaTesters.Infrastructure.Constants.DataConstants;

namespace BetaTesters.Core.Models.BetaProgram
{
	public class BetaProgramServiceModel
	{
		public Guid Id { get; set; }

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
		[Display(Name = "Image Url")]
		public string ImageUrl { get; set; } = string.Empty;
	}
}
