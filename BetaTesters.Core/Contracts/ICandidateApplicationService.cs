using BetaTesters.Core.Models.BetaProgram;
using BetaTesters.Core.Models.CandidateApplication;
using BetaTesters.Infrastructure.Data.Models;
using System.Threading.Tasks;

namespace BetaTesters.Core.Contracts
{
    public interface ICandidateApplicationService
    {
        System.Threading.Tasks.Task CreateAsync(CandidateApplicationFormModel model, string candidateId, string programId);

        Task<IEnumerable<CandidateApplicationViewModel>> ApplicationsByUserIdAsync(string userId);

        bool HasApplicationForCurrentUserAndProgram(string userId, string programId);

        System.Threading.Tasks.Task EditAsync(string id, CandidateApplicationFormModel model);

        Task<bool> ExistsAsync(string id);

        Task<CandidateApplicationFormModel> GetCandidateApplicationFormModelByIdAsync(string id);

        System.Threading.Tasks.Task DeleteAsync(string id);

        Task<CandidateApplicationViewModel> CandidateApplicationDetailsByIdAsync(string id);

        CandidateApplication GetById(string id);
    }
}
