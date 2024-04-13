using BetaTesters.Core.Contracts;
using BetaTesters.Infrastructure.Data.Enums;
using BetaTesters.Infrastructure.Data.Models;

namespace BetaTesters.Core.Services
{
    using BetaTesters.Core.Models.CandidateApplication;
    using BetaTesters.Infrastructure.Data.Common;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;
    public class CandidateApplicationService : ICandidateApplicationService
    {
        private readonly IRepository repository;
        public CandidateApplicationService(IRepository _repository)
        {
            repository = _repository;
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
                .FirstAsync();

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
                .FirstAsync();
        }

        public CandidateApplication GetById(string id)
        {
            return repository.AllReadOnly<CandidateApplication>()
                .First(a => a.Id == Guid.Parse(id));
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

        public async Task ApproveApplication(string applicationId, string userId)
        {
            await DeleteAsync(applicationId);
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
                .FirstAsync();
        }

        public Task ApproveApplication(string applicationId, string userId, string programId)
        {
            throw new NotImplementedException();
        }
    }
}
