using BetaTesters.Core.Contracts;
using BetaTesters.Infrastructure.Data.Common;
using BetaTesters.Infrastructure.Data.Models;

namespace BetaTesters.Core.Services
{
    using System.Threading.Tasks;
    public class ApplicationUserService : IApplicationUserService
	{
		private readonly IRepository repository;

		public ApplicationUserService(IRepository _repository)
		{
			repository = _repository;
		}

        public async Task<ApplicationUser> GetApplicationUserByIdAsync(string id)
		{
			return await repository
				.GetByIdAsync<ApplicationUser>(Guid.Parse(id));
		}

        public async Task SetProgramIdAsync(ApplicationUser user, string programId)
        {
			user.BetaProgramId = Guid.Parse(programId);

			await repository.SaveChangesAsync();
        }
    }
}
