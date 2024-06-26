﻿using BetaTesters.Core.Contracts;
using BetaTesters.Core.Extensions;
using BetaTesters.Core.Models.BetaProgram;
using BetaTesters.Infrastructure.Data.Common;
using BetaTesters.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using BetaTesters.Core.Models.BetaProgram.Owner;
using Microsoft.AspNetCore.Identity;
using static BetaTesters.Infrastructure.Constants.RoleConstants;
using BetaTesters.Infrastructure.Data.Enums;

namespace BetaTesters.Core.Services
{
    using BetaTesters.Infrastructure.Constants;
    using System.Threading.Tasks;
    public class BetaProgramService : IBetaProgramService
	{
		private readonly IRepository repository;
		private readonly IApplicationUserService applicationUserService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        public BetaProgramService(IRepository _repository,
			IApplicationUserService _applicationUserService,
            UserManager<ApplicationUser> _userManager,
            SignInManager<ApplicationUser> _signInManager)
		{
			repository = _repository;
			applicationUserService = _applicationUserService;
            userManager = _userManager;
            signInManager = _signInManager;
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

        public async Task<BetaProgram> BetaProgramByIdAsync(string id)
        {
            return await repository.AllReadOnly<BetaProgram>()
				.FirstOrDefaultAsync(b => b.Id == Guid.Parse(id));
        }

        public async Task<BetaProgramDetailsServiceModel> BetaProgramByOwnerId(string ownerId)
        {
			var program = await repository.AllReadOnly<BetaProgram>()
				.FirstAsync(b => b.Users.Any(u => u.Id == Guid.Parse(ownerId)));

			var owner = await applicationUserService.GetApplicationUserByIdAsync(ownerId);

			return await repository.AllReadOnly<BetaProgram>()
                .Where(p => p.Id == program.Id)
                .Select(p => new BetaProgramDetailsServiceModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    Owner = new OwnerServiceModel()
                    {
                        Email = owner.Email,
                        FirstName = owner.FirstName,
                        LastName = owner.LastName
                    },
                    TotalParticipants = p.Users.Count(),
                    TotalTasksCompleted = p.Tasks
                        .Where(t => t.State == TaskState.Completed)
                        .Count()
                })
                .FirstAsync();
        }

        public async Task<BetaProgramDataModel> BetaProgramByUserId(string userId)
        {
            var program = await repository.AllReadOnly<BetaProgram>()
                .FirstAsync(b => b.Users.Any(u => u.Id == Guid.Parse(userId)));

            return await repository.AllReadOnly<BetaProgram>()
                .Where(p => p.Id == program.Id)
                .Select(p => new BetaProgramDataModel()
                {
                    Id = p.Id,
                    Name = p.Name
                })
                .FirstAsync();
        }

        public async Task<BetaProgramDetailsServiceModel> BetaProgramDetailsByIdAsync(string id)
        {
			var owners = await repository.All<IdentityUserRole<Guid>>()
				.Where(u => u.RoleId == Guid.Parse(OwnerRoleId))
				.ToListAsync();

			List<Guid> ownerIds = owners
				.Select(o => o.UserId)
				.ToList();

			var currentProgramOwner = await repository.All<ApplicationUser>()
				.FirstOrDefaultAsync(u => ownerIds.Contains(u.Id) && u.BetaProgramId == Guid.Parse(id));

			if (currentProgramOwner == null)
			{
				throw new ArgumentNullException("Owner not found");
			}

			return await repository.AllReadOnly<BetaProgram>()
                .Where(p => p.Id == Guid.Parse(id))
                .Select(p => new BetaProgramDetailsServiceModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
					ImageUrl = p.ImageUrl,
					Owner = new OwnerServiceModel()
					{
						Email = currentProgramOwner.Email,
						FirstName = currentProgramOwner.FirstName,
						LastName = currentProgramOwner.LastName
					},
					TotalParticipants = p.Users.Count(),
					TotalTasksCompleted = p.Tasks
						.Where(t => t.State == TaskState.Completed)
						.Count()
				})
                .FirstAsync();
        }

        public async Task<Guid> CreateAsync(BetaProgramFormModel model)
        {
			var betaProgram = new BetaProgram()
			{
				Name = model.Name,
				Description = model.Description,
				ImageUrl = model.ImageUrl
			};

            await repository.AddAsync(betaProgram);
            await repository.SaveChangesAsync();

			return betaProgram.Id;
        }

        public async Task<bool> ExistsAsync(string id)
        {
            return await repository.AllReadOnly<BetaProgram>()
                .AnyAsync(p => p.Id == Guid.Parse(id));
        }

        public async Task<Guid> GetOwnerIdAsync(string programId)
        {
            var owners = await repository.All<IdentityUserRole<Guid>>()
                .Where(u => u.RoleId == Guid.Parse(OwnerRoleId))
                .ToListAsync();

            List<Guid> ownerIds = owners
                .Select(o => o.UserId)
                .ToList();

            var currentProgramOwner = await repository.All<ApplicationUser>()
                .FirstOrDefaultAsync(u => ownerIds.Contains(u.Id) && u.BetaProgramId == Guid.Parse(programId));

			return currentProgramOwner.Id;
        }

        public async Task LeaveAsync(string userId)
        {
            var user = await applicationUserService.GetApplicationUserByIdAsync(userId);

            if(await userManager.IsInRoleAsync(user, ModeratorRole))
            {
                await userManager.RemoveFromRoleAsync(user, ModeratorRole);
                await userManager.AddToRoleAsync(user, DefaultUserRole);
                await signInManager.SignInAsync(user, false);
            }

            user.BetaProgramId = null;

            await repository.SaveChangesAsync();
        }
    }
}
