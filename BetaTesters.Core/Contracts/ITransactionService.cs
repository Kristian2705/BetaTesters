using BetaTesters.Core.Models.Transaction;

namespace BetaTesters.Core.Contracts
{
    public interface ITransactionService
    {
        Task CreateTransactionAsync(TransactionServiceModel model);

        Task<IEnumerable<TransactionViewModel>> GetMyTransactionsAsync(string userId);
    }
}
