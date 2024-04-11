using BetaTesters.Core.Models.BetaProgram;

namespace BetaTesters.Core.Contracts
{
	public interface IBetaProgramService
	{
		Task<BetaProgramQueryServiceModel> AllAsync(int currentPage = 1, int programsPerPage = 1);
	}
}
