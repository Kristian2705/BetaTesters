using BetaTesters.Core.Models.Transaction;

namespace BetaTesters.Core.Contracts
{
    public interface ITransactionService
    {
        Task CreateTransactionAsync(TransactionServiceModel model);
    }
}
