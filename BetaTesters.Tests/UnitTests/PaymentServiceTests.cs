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
    public class PaymentServiceTests : UnitTestsBase
    {
        private IPaymentService paymentService;
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
            paymentService = new PaymentService(repository, userService);
        }

        [Test]
        public async Task GetAllReceivedPaymentsAsync_ShouldBeEmpty()
        {
            var result = await paymentService.GetAllReceivedPaymentsAsync(DefaultUser.Id.ToString());

            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task GetAllSentPaymentsAsync_ShouldBeEmpty()
        {
            var result = await paymentService.GetAllSentPaymentsAsync(Owner.Id.ToString());

            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task GetPaymentServiceModelByUserIdAsync_ShouldBeNull()
        {
            try
            {
                var result = await paymentService.GetPaymentServiceModelByUserIdAsync(DefaultUser.Id.ToString());
            }
            catch (ArgumentNullException ex)
            {
                Assert.That(ex.GetType(), Is.EqualTo(typeof(ArgumentNullException)));
            }
        }

        [Test]
        public async Task CreatePaymentAsync_ShouldFail()
        {
            try
            {
                await paymentService.CreatePaymentAsync(DefaultUser.Id.ToString(), Owner.Id.ToString(), 30);
            }
            catch(NullReferenceException ex)
            {
                Assert.That(ex.GetType(), Is.Not.Null);
            }
        }

        [Test]
        public async Task Constructor_ShoulWork()
        {
            var ps = new PaymentService(repository, userService);

            Assert.That(ps, Is.Not.Null);
        }
    }
}
