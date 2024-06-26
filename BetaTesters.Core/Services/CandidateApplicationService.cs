﻿using BetaTesters.Core.Contracts;
using BetaTesters.Infrastructure.Data.Enums;
using BetaTesters.Infrastructure.Data.Models;

namespace BetaTesters.Core.Services
{
    using BetaTesters.Core.Models.CandidateApplication;
    using BetaTesters.Data;
    using BetaTesters.Infrastructure.Data.Common;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;
    public class CandidateApplicationService : ICandidateApplicationService
    {
        private readonly IRepository repository;
        private readonly IApplicationUserService applicationUserService;
        public CandidateApplicationService(IRepository _repository,
            IApplicationUserService _applicationUserService)
        {
            repository = _repository;
            applicationUserService = _applicationUserService;
        }

        public async Task<IEnumerable<CandidateApplicationViewModel>> ApplicationsByUserIdAsync(string userId)
        {
            return await repository.AllReadOnly<CandidateApplication>()
                .Where(c => c.CandidateId == Guid.Parse(userId))
                .Select(c => new CandidateApplicationViewModel()
                {
                    Id = c.Id,
                    Motivation = c.Motivation,
                    Approval = c.Approval,
                    BetaProgramId = c.BetaProgramId.ToString(),
                    PhoneNumber = c.PhoneNumber
                })
                .ToListAsync();
        }

        public async Task CreateAsync(CandidateApplicationFormModel model, string candidateId, string programId)
        {
            var application = new CandidateApplication()
            {
                Motivation = model.Motivation,
                CandidateId = Guid.Parse(candidateId),
                BetaProgramId = Guid.Parse(programId),
                PhoneNumber = model.PhoneNumber,
                Approval = Approval.ToBeReviewed
            };
            
            await repository.AddAsync(application);

            await repository.SaveChangesAsync();
        }

        public async Task EditAsync(string id, CandidateApplicationFormModel model)
        {
            var application = await repository.GetByIdAsync<CandidateApplication>(Guid.Parse(id));

            if (application != null)
            {
                application.Motivation = model.Motivation;
                application.PhoneNumber = model.PhoneNumber;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(string id)
        {
            return await repository.AllReadOnly<CandidateApplication>()
                .AnyAsync(c => c.Id == Guid.Parse(id));
        }

        public async Task<CandidateApplicationFormModel> GetCandidateApplicationFormModelByIdAsync(string id)
        {
            var application = await repository.AllReadOnly<CandidateApplication>()
                .Where(c => c.Id == Guid.Parse(id))
                .Select(c => new CandidateApplicationFormModel()
                {
                    Motivation = c.Motivation,
                    PhoneNumber = c.PhoneNumber,
                })
                .FirstOrDefaultAsync();

            return application;
        }

        public bool HasApplicationForCurrentUserAndProgram(string userId, string programId)
        {
            return repository.AllReadOnly<CandidateApplication>()
                .Any(a => a.BetaProgramId == Guid.Parse(programId) && a.CandidateId == Guid.Parse(userId));
        }

        public async Task DeleteAsync(string id)
        {
            await repository.DeleteAsync<CandidateApplication>(Guid.Parse(id));
            await repository.SaveChangesAsync();
        }

        public async Task<CandidateApplicationViewModel> CandidateApplicationDetailsByIdAsync(string id)
        {
            return await repository.AllReadOnly<CandidateApplication>()
                .Where(c => c.Id == Guid.Parse(id))
                .Select(c => new CandidateApplicationViewModel()
                {
                    Id = c.Id,
                    Motivation = c.Motivation,
                    PhoneNumber = c.PhoneNumber,
                    BetaProgramId = c.BetaProgramId.ToString(),
                    Approval = c.Approval
                })
                .FirstOrDefaultAsync();
        }

        public CandidateApplication GetById(string id)
        {
            return repository.AllReadOnly<CandidateApplication>()
                .FirstOrDefault(a => a.Id == Guid.Parse(id));
        }

        public async Task<IEnumerable<CandidateApplicationInspectModel>> ApplicationsByProgramIdAsync(string programId)
        {
            return await repository.AllReadOnly<CandidateApplication>()
                .Where(c => c.BetaProgramId == Guid.Parse(programId))
                .Select(c => new CandidateApplicationInspectModel()
                {
                    Id = c.Id,
                    Motivation = c.Motivation,
                    PhoneNumber = c.PhoneNumber,
                    Candidate =  c.Candidate
                })
                .ToListAsync();
        }

        public async Task ApproveApplicationAsync(string applicationId, string userId, string programId)
        {
            var user = await applicationUserService.GetApplicationUserByIdAsync(userId);

            await applicationUserService.SetProgramIdAsync(user, programId);

            var applications = await GetAllApplicationsByUserId(userId);

            repository.DeleteRange(applications);

            await repository.SaveChangesAsync();
        }

        public async Task<CandidateApplicationInspectModel> CandidateApplicationInspectDetailsByIdAsync(string applicationId)
        {
            return await repository.AllReadOnly<CandidateApplication>()
                .Where(c => c.Id == Guid.Parse(applicationId))
                .Select(c => new CandidateApplicationInspectModel()
                {
                    Id = c.Id,
                    Motivation = c.Motivation,
                    PhoneNumber = c.PhoneNumber,
                    Candidate = c.Candidate,
                    BetaProgramId = c.BetaProgramId
                })
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<CandidateApplication>> GetAllApplicationsByUserId(string userId)
        {
            return await repository.AllReadOnly<CandidateApplication>()
                .Where(c => c.CandidateId == Guid.Parse(userId))
                .ToListAsync();
        }
    }
}
