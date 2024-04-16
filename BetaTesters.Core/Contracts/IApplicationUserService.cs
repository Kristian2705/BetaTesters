using BetaTesters.Infrastructure.Data.Models;

namespace BetaTesters.Core.Contracts
{
    using BetaTesters.Core.Models.ApplicationUserModels;
    using System.Threading.Tasks;
	public interface IApplicationUserService
	{
		Task<ApplicationUser> GetApplicationUserByIdAsync(string id);

		Task SetProgramIdAsync(ApplicationUser user, string programId);

		Task<IEnumerable<ApplicationUserViewModel>> GetUsersByProgramId(string programId);

        Task<IEnumerable<ApplicationUserViewModel>> GetModeratorsByProgramId(string programId);

		Task PromoteUserToModeratorAsync(ApplicationUser user);

        ApplicationUserViewModel GetApplicationUserViewModelByUser(ApplicationUser user);

        Task KickUserFromProgramAsync(ApplicationUser user);

        Task<ApplicationUserViewModel> GetApplicationUserViewModelByUserId(string userId);

        Task<ApplicationUser> GetApplicationUserWithTasksByIdAsync(string userId);

        Task<IEnumerable<ApplicationUserViewModel>> GetAllApplicationUsersViewModelsAsync();
    }
}
