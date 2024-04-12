using BetaTesters.Core.Models.BetaProgram;
using BetaTesters.Infrastructure.Data.Models;

namespace BetaTesters.Core.Contracts
{
	public interface IBetaProgramService
	{
		Task<BetaProgramQueryServiceModel> AllAsync(int currentPage = 1, int programsPerPage = 1);

		Task<BetaProgramDetailsServiceModel> BetaProgramDetailsByIdAsync(string id);

		Task<bool> ExistsAsync(string id);

		Task<BetaProgram> BetaProgramByIdAsync(string id);
    }
}
