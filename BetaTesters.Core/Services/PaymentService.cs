using BetaTesters.Core.Contracts;
using BetaTesters.Core.Models.Payment;
using BetaTesters.Infrastructure.Data.Common;
using BetaTesters.Infrastructure.Data.Models;
using BetaTesters.Infrastructure.Data.Enums;

namespace BetaTesters.Core.Services
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public class PaymentService : IPaymentService
    {
        private readonly IRepository repository;
        private readonly IApplicationUserService applicationUserService;

        public PaymentService(IRepository _repository,
            IApplicationUserService _applicationUserService)
        {
            repository = _repository;
            applicationUserService = _applicationUserService;
        }

        public async Task CreatePaymentAsync(string receiverId, string senderId, decimal amount)
        {
            var receiver = await applicationUserService.GetApplicationUserWithTasksByIdAsync(receiverId);

            var sender = await applicationUserService.GetApplicationUserByIdAsync(senderId);

            receiver.Balance += amount;
            sender.Balance -= amount;

            if (sender.Balance < 0)
            {
                throw new ArgumentException("You don't have enough money to create the payment");
            }

            foreach (var completedTask in receiver.Tasks.Where(t => t.State == TaskState.Completed && t.IsPaidFor == false))
            {
                completedTask.IsPaidFor = true;
            }

            var payment = new Payment()
            {
                SenderId = Guid.Parse(senderId),
                ReceiverId = Guid.Parse(receiverId),
                Money = amount
            };

            await repository.AddAsync(payment);

            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<PaymentViewModel>> GetAllReceivedPaymentsAsync(string receiverId)
        {
            return await repository.AllReadOnly<Payment>()
                .Where(p => p.ReceiverId == Guid.Parse(receiverId))
                .Select(p => new PaymentViewModel()
                {
                    Amount = p.Money,
                    Sender = p.Sender,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<PaymentViewModel>> GetAllSentPaymentsAsync(string ownerId)
        {
            return await repository.AllReadOnly<Payment>()
                .Where(p => p.SenderId == Guid.Parse(ownerId))
                .Select(p => new PaymentViewModel()
                {
                    Amount = p.Money,
                    Receiver = p.Receiver,
                })
                .ToListAsync();
        }

        public async Task<PaymentServiceModel> GetPaymentServiceModelByUserIdAsync(string userId)
        {
            var userViewModel = await applicationUserService.GetApplicationUserViewModelByUserId(userId);

            var paymentDetails = new PaymentServiceModel()
            {
                Money = (decimal)userViewModel.MoneyToTransfer!,
                ReceiverId = userId,
                Receiver = userViewModel
            };

            return paymentDetails;
        }
    }
}
