using BetaTesters.Core.Contracts;
using BetaTesters.Core.Services;
using BetaTesters.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;


namespace BetaTesters.Tests.UnitTests
{
    using BetaTesters.Core.Models.ApplicationUserModels;
    using System.Threading.Tasks;
    using System.Web;

    [TestFixture]
    public class ApplicationUserServiceTests : UnitTestsBase
    {
        private IApplicationUserService applicationUserService;

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

            applicationUserService = new ApplicationUserService(repository, userManagerMock.Object);
        }

        [Test]
        public async Task GetApplicationUserByIdAsync_ShouldFail()
        {
            var result = await applicationUserService.GetApplicationUserByIdAsync(DefaultUser.Id.ToString());

            Assert.That(result, Is.EqualTo(null));
        }

        [Test]
        public async Task GetApplicationUserWithTasksByIdAsync_ShouldFail()
        {
            var result = await applicationUserService.GetApplicationUserWithTasksByIdAsync(DefaultUser.Id.ToString());

            Assert.That(result, Is.EqualTo(null));
        }

        [Test]
        public async Task GetApplicationUserViewModelByUser_ShouldHappen()
        {
            var result = applicationUserService.GetApplicationUserViewModelByUser(DefaultUser);

            var userViewModel = new ApplicationUserViewModel()
            {
                Id = DefaultUser.Id,
                FirstName = DefaultUser.FirstName,
                LastName = DefaultUser.LastName,
                Email = DefaultUser.Email,
                BetaProgramId = DefaultUser.BetaProgramId.ToString(),
            };

            Assert.That(result.Id, Is.EqualTo(userViewModel.Id));
        }

        [Test]
        public async Task SetProgramIdAsync_ShouldHappen()
        {
            await applicationUserService.SetProgramIdAsync(DefaultUser, FacebookProgram.Id.ToString());

            Assert.That(DefaultUser.BetaProgramId, Is.EqualTo(FacebookProgram.Id));
        }

        [Test]
        public async Task GetAllApplicationUsersViewModelsAsync_ShouldBeEmpty()
        {
            var result = await applicationUserService.GetAllApplicationUsersViewModelsAsync();

            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task GetUsersByProgramId_ShouldFail()
        {
            var result = await applicationUserService.GetUsersByProgramId(FacebookProgram.Id.ToString());

            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task GetModeratorsByProgramId_ShouldFail()
        {
            var result = await applicationUserService.GetModeratorsByProgramId(FacebookProgram.Id.ToString());

            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task GetApplicationUserViewModelByUserId_ShouldFail()
        {
            try
            {
                var result = await applicationUserService.GetApplicationUserViewModelByUserId(DefaultUser.Id.ToString());
            }
            catch (ArgumentNullException ex)
            {
                Assert.That(ex.GetType(), Is.EqualTo(typeof(ArgumentNullException)));
            }
        }
    }
}
