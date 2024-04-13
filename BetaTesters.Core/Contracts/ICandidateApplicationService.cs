using BetaTesters.Core.Models.CandidateApplication;
using BetaTesters.Infrastructure.Data.Models;

namespace BetaTesters.Core.Contracts
{
    using System.Threading.Tasks;
    public interface ICandidateApplicationService
    {
        Task CreateAsync(CandidateApplicationFormModel model, string candidateId, string programId);

        Task<IEnumerable<CandidateApplicationViewModel>> ApplicationsByUserIdAsync(string userId);

        bool HasApplicationForCurrentUserAndProgram(string userId, string programId);

        Task EditAsync(string id, CandidateApplicationFormModel model);

        Task<bool> ExistsAsync(string id);

        Task<CandidateApplicationFormModel> GetCandidateApplicationFormModelByIdAsync(string id);

        Task DeleteAsync(string id);

        Task<CandidateApplicationViewModel> CandidateApplicationDetailsByIdAsync(string id);

        CandidateApplication GetById(string id);

        Task<IEnumerable<CandidateApplicationInspectModel>> ApplicationsByProgramIdAsync(string programId);

        Task ApproveApplication(string applicationId, string userId, string programId);

        Task<CandidateApplicationInspectModel> CandidateApplicationInspectDetailsByIdAsync(string applicationId);
    }
}
