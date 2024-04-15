using BetaTesters.Core.Contracts;
using BetaTesters.Infrastructure.Data.Common;
using BetaTesters.Infrastructure.Data.Models;

namespace BetaTesters.Core.Services
{
    using BetaTesters.Core.Models.ApplicationUserModels;
    using BetaTesters.Infrastructure.Constants;
    using BetaTesters.Infrastructure.Data.Enums;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public class ApplicationUserService : IApplicationUserService
	{
		private readonly IRepository repository;
        private readonly UserManager<ApplicationUser> userManager;

		public ApplicationUserService(IRepository _repository, UserManager<ApplicationUser> _userManager)
		{
			repository = _repository;
            userManager = _userManager;
		}

        public async Task<ApplicationUser> GetApplicationUserByIdAsync(string id)
		{
			return await repository
				.GetByIdAsync<ApplicationUser>(Guid.Parse(id));
		}

        public ApplicationUserViewModel GetApplicationUserViewModelByUser(ApplicationUser user)
        {
            var userViewModel = new ApplicationUserViewModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                BetaProgramId = user.BetaProgramId.ToString(),
            };

            return userViewModel;
        }

        public async Task<IEnumerable<ApplicationUserViewModel>> GetModeratorsByProgramId(string programId)
        {
            var moderators = await repository.AllReadOnly<ApplicationUser>()
                .Where(u => u.BetaProgramId == Guid.Parse(programId))
                .Include(u => u.CreatedTasks)
                .ToListAsync();

            var usersToDisplay = new List<ApplicationUserViewModel>();
            foreach (var moderator in moderators)
            {
                if (await userManager.IsInRoleAsync(moderator, RoleConstants.ModeratorRole))
                {
                    var userToDisplay = new ApplicationUserViewModel()
                    {
                        Id = moderator.Id,
                        Email = moderator.Email,
                        CreatedTasksCount = moderator.CreatedTasks
                            .Where(t => t.CreatorId == moderator.Id && t.ProgramId == Guid.Parse(programId))
                            .Count(),
                        FirstName = moderator.FirstName,
                        LastName = moderator.LastName
                    };

                    usersToDisplay.Add(userToDisplay);
                }
            }

            return usersToDisplay;
        }

        public async Task<IEnumerable<ApplicationUserViewModel>> GetUsersByProgramId(string programId)
        {
            var users = await repository.AllReadOnly<ApplicationUser>()
                .Where(u => u.BetaProgramId == Guid.Parse(programId))
                .Include(u => u.Tasks)
                .ToListAsync();

            var usersToDisplay = new List<ApplicationUserViewModel>();
            foreach(var user in users)
            {
                if(await userManager.IsInRoleAsync(user, RoleConstants.DefaultUserRole))
                {
                    var userToDisplay = new ApplicationUserViewModel()
                    {
                        Id = user.Id,
                        Email = user.Email,
                        CompletedTasksCount = user.Tasks
                            .Where(t => t.State == TaskState.Completed && t.ProgramId == Guid.Parse(programId))
                            .Count(),
                        InProgressTasksCount = user.Tasks
                            .Where(t => t.State == TaskState.InProgress && t.ProgramId == Guid.Parse(programId))
                            .Count(),
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        MoneyToTransfer = user.Tasks
                            .Where(t => t.IsPaidFor == false && t.ProgramId == Guid.Parse(programId) && t.State == TaskState.Completed)
                            .Sum(t => t.Reward),
                    };

                    usersToDisplay.Add(userToDisplay);
                }
            }

            return usersToDisplay;
        }

        public async Task PromoteUserToModeratorAsync(ApplicationUser user)
        {
            await userManager.RemoveFromRoleAsync(user, RoleConstants.DefaultUserRole);
            await userManager.AddToRoleAsync(user, RoleConstants.ModeratorRole);

            await repository.SaveChangesAsync();
        }

        public async Task SetProgramIdAsync(ApplicationUser user, string programId)
        {
			user.BetaProgramId = Guid.Parse(programId);

			await repository.SaveChangesAsync();
        }
    }
}
