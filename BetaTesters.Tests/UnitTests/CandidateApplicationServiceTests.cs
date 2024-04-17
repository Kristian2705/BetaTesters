using BetaTesters.Core.Contracts;
using BetaTesters.Core.Services;
using BetaTesters.Infrastructure.Data.Models;

namespace BetaTesters.Tests.UnitTests
{
    using BetaTesters.Core.Models.CandidateApplication;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Moq;
    using System.Threading.Tasks;

    [TestFixture]
    public class CandidateApplicationServiceTests : UnitTestsBase
    {
        private ICandidateApplicationService candidateApplicationService;
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

            userService = new ApplicationUserService(repository, userManagerMock.Object);
            candidateApplicationService = new CandidateApplicationService(repository, userService);
        }

        [Test]
        public async Task ApplicationsByUserIdAsync_ShouldReturnEmptyCollection()
        {
            var result = await candidateApplicationService.ApplicationsByUserIdAsync(DefaultUser.Id.ToString());

            Assert.That(result, Is.EqualTo(new List<CandidateApplication>()));
        }

        [Test]
        public async Task ExistsAsync_ShouldReturnFalse()
        {
            var result = await candidateApplicationService.ExistsAsync(Admin.Id.ToString());

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task HasApplicationForCurrentUserAndProgram_ShouldReturnFalse()
        {
            var result = candidateApplicationService.HasApplicationForCurrentUserAndProgram(Admin.Id.ToString(), FacebookProgram.Id.ToString());

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task CandidateApplicationDetailsByIdAsync_ShouldReturnNull()
        {
            var result = await candidateApplicationService.CandidateApplicationDetailsByIdAsync(Admin.Id.ToString());

            Assert.That(result, Is.EqualTo(null));
        }

        [Test]
        public async Task GetById_ShouldReturnNull()
        {
            var result = candidateApplicationService.GetById(Admin.Id.ToString());

            Assert.That(result, Is.EqualTo(null));
        }

        [Test]
        public async Task ApplicationsByProgramIdAsync_ShouldReturnEmptyCollection()
        {
            var result = await candidateApplicationService.ApplicationsByProgramIdAsync(FacebookProgram.Id.ToString());

            Assert.That(result, Is.EqualTo(new List<CandidateApplicationInspectModel>()));
        }

        [Test]
        public async Task CandidateApplicationInspectDetailsByIdAsync_ShouldReturnNull()
        {
            var result = await candidateApplicationService.CandidateApplicationInspectDetailsByIdAsync(FacebookProgram.Id.ToString());

            Assert.That(result, Is.EqualTo(null));
        }

        [Test]
        public async Task GetAllApplicationsByUserId_ShouldReturnEmptyCollection()
        {
            var result = await candidateApplicationService.GetAllApplicationsByUserId(Admin.Id.ToString());

            Assert.That(result, Is.EqualTo(new List<CandidateApplication>()));
        }

        [Test]
        public async Task GetCandidateApplicationFormModelByIdAsync_ShouldReturnEmptyCollection()
        {
            var result = await candidateApplicationService.GetCandidateApplicationFormModelByIdAsync(Admin.Id.ToString());

            Assert.That(result, Is.EqualTo(null));
        }

        [Test]
        public async Task CreateAsync_ShouldAddCorrectly()
        {
            var model = new CandidateApplicationFormModel()
            {
                Motivation = "djfijfg",
                PhoneNumber = "1234567890",
                BetaProgramId = FacebookProgram.Id.ToString(),
            };

            await candidateApplicationService.CreateAsync(model, DefaultUser.Id.ToString(), FacebookProgram.Id.ToString());

            Assert.That(repository.AllReadOnly<CandidateApplication>().Count(), Is.EqualTo(1));
        }
    }
}
