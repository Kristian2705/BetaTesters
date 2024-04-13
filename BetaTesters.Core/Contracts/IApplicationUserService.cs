using BetaTesters.Infrastructure.Data.Models;

namespace BetaTesters.Core.Contracts
{
	using System.Threading.Tasks;
	public interface IApplicationUserService
	{
		Task<ApplicationUser> GetApplicationUserByIdAsync(string id);

		Task SetProgramIdAsync(ApplicationUser user, string programId);

		Task ClearUserApplicationsAsync(ApplicationUser user);
	}
}
