using BetaTesters.Core.Contracts;
using BetaTesters.Core.Models.Transaction;
using BetaTesters.Infrastructure.Constants;
using BetaTesters.PaymentIntegration.Stripe;
using MessagePack.Formatters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Stripe;
using Stripe.Checkout;
using System.Security.Claims;
using static BetaTesters.Infrastructure.Constants.RoleConstants;

namespace BetaTesters.Controllers
{
    [Authorize(Roles = OwnerRole)]
    public class TransactionController : BaseController
    {
        private readonly StripeSettings stripeSettings;
        private readonly IApplicationUserService applicationUserService;

        public TransactionController(IOptions<StripeSettings> _stripeSettings,
            IApplicationUserService _applicationUserService)
        {
            stripeSettings = _stripeSettings.Value;
            applicationUserService = _applicationUserService;
        }

        public string SessionId {  get; set; }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            var transaction = new TransactionServiceModel()
            {
                UserId = user.Id.ToString(),
                Email = user.Email
            };

            return View(transaction);
        }

        [HttpPost]
        public IActionResult CreateCheckoutSession(TransactionServiceModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var currency = "bgn";

            var successUrl = $"https://localhost:7231/Transaction/OrderConfirmation";
            var cancelUrl = $"https://localhost:7231/Transaction/Cancel";

            StripeConfiguration.ApiKey = stripeSettings.SecretKey;

            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                    "card"
                },
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            Currency = currency,
                            UnitAmount = Convert.ToInt32(model.Money) * 100,
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = model.Type.ToString()
                            }

                        },
                        Quantity = 1
                    }
                },
                Mode = "payment",
                SuccessUrl = successUrl,
                CancelUrl = cancelUrl,
                CustomerEmail = model.Email
            };

            var service = new SessionService();
            var session = service.Create(options);
            SessionId = session.Id;
            
            return Redirect(session.Url);
        }
    }
}
