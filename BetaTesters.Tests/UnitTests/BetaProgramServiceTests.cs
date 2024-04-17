using BetaTesters.Core.Contracts;
using BetaTesters.Core.Services;
using BetaTesters.Infrastructure.Data.Common;
using BetaTesters.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BetaTesters.Tests.UnitTests
{
    using BetaTesters.Core.Models.BetaProgram;
    using System.Threading.Tasks;
    [TestFixture]
    public class BetaProgramServiceTests : UnitTestsBase
    {
        private IBetaProgramService betaProgramService;
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
            betaProgramService = new BetaProgramService(repository, userService, userManagerMock.Object, null);
        }

        [Test]
        public async Task BetaProgramByIdAsync_ShouldReturnNull()
        {
            var result = await betaProgramService.BetaProgramByIdAsync(Admin.Id.ToString());

            Assert.That(result, Is.EqualTo(null));
        }

        [Test]
        public async Task ExistsAsync_ShouldReturnFalse()
        {
            var result = await betaProgramService.ExistsAsync(Admin.Id.ToString());

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public async Task CreateAsync_ShouldHappen()
        {
            var model = new BetaProgramFormModel()
            {
                Description = "description",
                ImageUrl = FacebookProgram.ImageUrl,
                Name = "name",
            };

            await betaProgramService.CreateAsync(model);

            Assert.That(repository.AllReadOnly<BetaProgram>().Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task BetaProgramDetailsByIdAsync_ShouldFail()
        {
            try
            {
                var result = await betaProgramService.BetaProgramDetailsByIdAsync(FacebookProgram.Id.ToString());
            }
            catch(ArgumentNullException ex)
            {
                Assert.That(ex.GetType(), Is.EqualTo(typeof(ArgumentNullException)));
            }
        }

        [Test]
        public async Task BetaProgramByUserId_ShouldHappen()
        {
            var result = betaProgramService.BetaProgramByUserId(DefaultUser.Id.ToString());

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task BetaProgramByOwnerId_ShouldHappen()
        {
            var result = betaProgramService.BetaProgramByOwnerId(Owner.Id.ToString());

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task GetOwnerIdAsync_ShouldFail()
        {
            var result = betaProgramService.GetOwnerIdAsync(FacebookProgram.Id.ToString());

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task AllAsync_ShouldFail()
        {
            var result = await betaProgramService.AllAsync();

            Assert.That(result, Is.Not.Null);
        }
    }
}
