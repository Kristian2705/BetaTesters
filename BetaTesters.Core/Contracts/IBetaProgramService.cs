﻿using BetaTesters.Core.Models.BetaProgram;
using BetaTesters.Infrastructure.Data.Models;

namespace BetaTesters.Core.Contracts
{
    using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
    using System.Threading.Tasks;

    public interface IBetaProgramService
	{
		Task<BetaProgramQueryServiceModel> AllAsync(int currentPage = 1, int programsPerPage = 1);

		Task<BetaProgramDetailsServiceModel> BetaProgramDetailsByIdAsync(string id);

		Task<bool> ExistsAsync(string id);

		Task<BetaProgram> BetaProgramByIdAsync(string id);

        Task<Guid> CreateAsync(BetaProgramFormModel model);

		Task<Guid> GetOwnerIdAsync(string programId);

		Task<BetaProgramDetailsServiceModel> BetaProgramByOwnerId(string ownerId);

        Task<BetaProgramDataModel> BetaProgramByUserId(string userId);

		Task LeaveAsync(string userId);
    }
}
