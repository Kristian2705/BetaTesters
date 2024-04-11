using BetaTesters.Core.Models.CandidateApplication;

namespace BetaTesters.Core.Contracts
{
    public interface ICandidateApplicationService
    {
        Task CreateAsync(CandidateApplicationFormModel model, string candidateId, string programId);
    }
}
