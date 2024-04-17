using BetaTesters.Core.Contracts;
using BetaTesters.Core.Services;
using BetaTesters.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;

namespace BetaTesters.Tests.UnitTests
{
    using System.Threading.Tasks;
    [TestFixture]
    public class TransactionServiceTests : UnitTestsBase
    {
        private ITransactionService transactionService;
        private IApplicationUserService userService;

        [OneTimeSetUp]
        public void SetUp()
        {
            var userManagerMock = new Mock<UserManager<ApplicationUser>>(
                new Mock<IUserStore<ApplicationUser>>().Object,
                new Mock<IOptions<IdentityOptions>>().Object,
                new Mock<IPasswordHasher<ApplicationUser>>().Object,
                new IUserValidator<ApplicationUser>[0],
                new IPasswordValidator<ApplicationUser>[0],
                new Mock<ILookupNormalizer>().Object,
                new Mock<IdentityErrorDescriber>().Object,
                new Mock<IServiceProvider>().Object,
                new Mock<ILogger<UserManager<ApplicationUser>>>().Object);

            userManagerMock
                .Setup(userManager => userManager.GetRolesAsync(It.IsAny<ApplicationUser>()));

            userManagerMock
                .Setup(userManager => userManager.AddToRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()));

            userManagerMock
                .Setup(userManager => userManager.RemoveFromRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()));
            userManagerMock
                .Setup(userManager => userManager.IsInRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()));

            var signInManagerMock = new Mock<SignInManager<ApplicationUser>>();

            userService = new ApplicationUserService(repository, userManagerMock.Object);
            transactionService = new TransactionService(repository, userService);
        }

        [Test]
        public async Task GetAllTransactionsAsync_ShouldBeEmpty()
        {
            var result = await transactionService.GetAllTransactionsAsync();

            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task GetMyTransactionsAsync_ShouldBeEmpty()
        {
            var result = await transactionService.GetMyTransactionsAsync(Owner.Id.ToString());

            Assert.That(result, Is.Empty);
        }
    }
}
