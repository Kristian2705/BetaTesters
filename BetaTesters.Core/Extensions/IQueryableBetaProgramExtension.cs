using BetaTesters.Core.Models.BetaProgram;
using BetaTesters.Infrastructure.Data.Models;

namespace BetaTesters.Core.Extensions
{
	public static class IQueryableBetaProgramExtension
	{
		public static IQueryable<BetaProgramServiceModel> ProjectToBetaProgramServiceModel(this IQueryable<BetaProgram> betaPrograms)
		{
			return betaPrograms
				.Select(p => new BetaProgramServiceModel()
				{
					Id = p.Id,
					Name = p.Name,
					Description = p.Description,
					ImageUrl = p.ImageUrl
				});
		}
	}
}
