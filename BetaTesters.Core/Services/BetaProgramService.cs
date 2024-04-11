using BetaTesters.Core.Contracts;
using BetaTesters.Core.Extensions;
using BetaTesters.Core.Models.BetaProgram;
using BetaTesters.Infrastructure.Data.Common;
using BetaTesters.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BetaTesters.Core.Services
{
	public class BetaProgramService : IBetaProgramService
	{
		private readonly IRepository repository;
		public BetaProgramService(IRepository _repository)
		{
			repository = _repository;
		}
		public async Task<BetaProgramQueryServiceModel> AllAsync(int currentPage = 1, int programsPerPage = 1)
		{
			var programsToShow = repository.AllReadOnly<BetaProgram>();

			var betaPrograms = await programsToShow
				.Skip((currentPage - 1) * programsPerPage)
				.Take(programsPerPage)
				.ProjectToBetaProgramServiceModel()
				.ToListAsync();

			int totalBetaPrograms = await programsToShow.CountAsync();

			return new BetaProgramQueryServiceModel()
			{
				BetaPrograms = betaPrograms,
				TotalBetaProgramsCount = totalBetaPrograms
			};
		}
	}
}
