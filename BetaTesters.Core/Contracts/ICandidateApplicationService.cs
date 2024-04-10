using BetaTesters.Core.Models;

namespace BetaTesters.Core.Contracts
{
    public interface ICandidateApplicationService
    {
        Task CreateAsync(CandidateApplicationFormModel model, string candidateId, string programId);
    }
}
