using BetaTesters.Core.Contracts;
using BetaTesters.Core.Models.ApplicationUserModels;
using BetaTesters.Core.Models.Transaction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using static BetaTesters.Areas.Admin.AdminConstants;

namespace BetaTesters.Areas.Admin.Controllers
{
    public class UserController : AdminBaseController
    {
        private readonly IApplicationUserService applicationUserService;
        private readonly ITransactionService transactionService;
        private readonly IMemoryCache cache;

        public UserController(IApplicationUserService _applicationUserService,
            IMemoryCache _cache,
            ITransactionService _transactionService)
        {
            applicationUserService = _applicationUserService;
            cache = _cache;
            transactionService = _transactionService;
        }

        [Route("Users/All")]
        public async Task<IActionResult> All()
        {
            var users = cache
                .Get<IEnumerable<ApplicationUserViewModel>>(UsersCacheKey);

            if(users == null)
            {
                users = await applicationUserService.GetAllApplicationUsersViewModelsAsync();

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));

                cache.Set(UsersCacheKey, users, cacheOptions);
            }

            return View(users);
        }

        [Route("Users/Transactions")]
        public async Task<IActionResult> AllTransactions()
        {
            var transactions = cache
                .Get<IEnumerable<AllTransactionsViewModel>>(TransactionsCacheKey);

            if(transactions == null)
            {
                transactions = await transactionService.GetAllTransactionsAsync();

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));

                cache.Set(TransactionsCacheKey, transactions, cacheOptions);
            }

            return View(transactions);
        }
    }
}
