using BetaTesters.Core.Contracts;
using BetaTesters.Core.Models.Transaction;
using BetaTesters.Infrastructure.Data.Models;
using BetaTesters.Infrastructure.Data.Enums;

namespace BetaTesters.Core.Services
{
    using BetaTesters.Infrastructure.Data.Common;
    using System.Threading.Tasks;
    public class TransactionService : ITransactionService
    {
        private readonly IRepository repository;
        private readonly IApplicationUserService applicationUserService;

        public TransactionService(IRepository _repository,
            IApplicationUserService _applicationUserService)
        {
            repository = _repository;
            applicationUserService = _applicationUserService;
        }

        public async Task CreateTransactionAsync(TransactionServiceModel model)
        {
            var transaction = new Transaction()
            {
                Money = model.Money,
                Type = model.Type,
                UserId = Guid.Parse(model.UserId)
            };

            var user = await applicationUserService.GetApplicationUserByIdAsync(model.UserId);
            if (model.Type == TransactionType.Аddition)
            {
                user.Balance += model.Money;
            }
            else
            {
                user.Balance -= model.Money;
            }

            await repository.AddAsync(transaction);
            
            await repository.SaveChangesAsync();
        }
    }
}
