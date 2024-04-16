using BetaTesters.Core.Models.Payment;

namespace BetaTesters.Core.Contracts
{
    using System.Threading.Tasks;
    public interface IPaymentService
    {
        Task<PaymentServiceModel> GetPaymentServiceModelByUserIdAsync(string userId);

        Task CreatePaymentAsync(string receiverId, string senderId, decimal amount);

        Task<IEnumerable<PaymentViewModel>> GetAllSentPaymentsAsync(string ownerId);

        Task<IEnumerable<PaymentViewModel>> GetAllReceivedPaymentsAsync(string receiverId);
    }
}
