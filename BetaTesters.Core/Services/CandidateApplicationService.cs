using BetaTesters.Core.Contracts;
using BetaTesters.Infrastructure.Data.Models;
using BetaTesters.Infrastructure.Data.Enums;

namespace BetaTesters.Core.Services
{
    using BetaTesters.Core.Models.CandidateApplication;
    using BetaTesters.Infrastructure.Data.Common;
    using System.Threading.Tasks;
    public class CandidateApplicationService : ICandidateApplicationService
    {
        private readonly IRepository repository;
        public CandidateApplicationService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task CreateAsync(CandidateApplicationFormModel model, string candidateId, string programId)
        {
            var application = new CandidateApplication()
            {
                Motivation = model.Motivation,
                CandidateId = Guid.Parse(candidateId),
                BetaProgramId = Guid.Parse(programId),
                PhoneNumber = model.PhoneNumber,
                Approval = Approval.ToBeReviewed,
                IsDeleted = false
            };
            
            await repository.AddAsync(application);
            await repository.SaveChangesAsync();
        }
    }
}
