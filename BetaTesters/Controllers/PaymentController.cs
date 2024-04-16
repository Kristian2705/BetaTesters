using static BetaTesters.Infrastructure.Constants.RoleConstants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BetaTesters.Core.Contracts;
using System.Security.Claims;
using BetaTesters.Core.Models.Payment;

namespace BetaTesters.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IPaymentService paymentService;
        private readonly IApplicationUserService applicationUserService;

        public PaymentController(IPaymentService _paymentService,
            IApplicationUserService _applicationUserService)
        {
            paymentService = _paymentService;
            applicationUserService = _applicationUserService;
        }

        [HttpGet]
        [Authorize(Roles = OwnerRole)]
        public async Task<IActionResult> Create(string userId)
        {
            if(userId == null)
            {
                return BadRequest();
            }

            var user = await applicationUserService.GetApplicationUserByIdAsync(userId);

            var sender = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            if(user.BetaProgramId != sender.BetaProgramId)
            {
                return Forbid();
            }

            var paymentDetails = await paymentService.GetPaymentServiceModelByUserIdAsync(userId);

            return View(paymentDetails);
        }

        [HttpPost]
        [Authorize(Roles = OwnerRole)]
        public async Task<IActionResult> Create(PaymentServiceModel model)
        {
            if(model.Money == 0)
            {
                return BadRequest();
            }

            if(!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await paymentService.CreatePaymentAsync(model.ReceiverId.ToString(), User.Id(), model.Money);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpGet]
        [Authorize(Roles = OwnerRole)]
        public async Task<IActionResult> Sent(string ownerId)
        {
            if(ownerId == null)
            {
                return BadRequest();
            }

            var payments = await paymentService.GetAllSentPaymentsAsync(ownerId);

            return View(payments);
        }
    }
}
