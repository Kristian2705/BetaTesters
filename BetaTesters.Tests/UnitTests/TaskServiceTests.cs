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
    using BetaTesters.Core.Enums;
    using BetaTesters.Core.Models.Task;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading.Tasks;

    [TestFixture]
    public class TaskServiceTests : UnitTestsBase
    {
        private ITaskService taskService;
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
            taskService = new TaskService(repository, userService);
        }

        [Test]
        public async Task AllCategoriesAsync_ShouldFail()
        {
            var result = await taskService.AllCategoriesAsync();

            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task AllCategoriesNameAsync_ShouldFail()
        {
            var result = await taskService.AllCategoriesNameAsync();

            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task CategoryExistsAsync_ShouldFail()
        {
            var result = await taskService.CategoryExistsAsync(NewFeatureCategory.Id);

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task CreateAsync_ShouldHappen()
        {
            var model = new TaskFormModel()
            {
                Name = FirstTask.Name,
                Description = FirstTask.Description,
                Approval = FirstTask.Approval,
                CategoryId = FirstTask.CategoryId,
                Reward = FirstTask.Reward,
                TaskState = FirstTask.State,
                ProgramId = FirstTask.ProgramId.ToString()
            };

            await taskService.CreateAsync(model, FirstTask.CreatorId.ToString(), DateTime.Now);

            Assert.That(repository.AllReadOnly<Infrastructure.Data.Models.Task>().Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task GetAllTasksCountForCurrentProgramAsync_ShouldReturn1()
        {
            var result = await taskService.GetAllTasksCountForCurrentProgramAsync(FacebookProgram.Id.ToString());

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public async Task TaskWaitListByProgramIdAsync_ShouldBeEmpty()
        {
            var result = await taskService.TaskWaitListByProgramIdAsync(FacebookProgram.Id.ToString());

            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task TaskInspectViewModelByIdAsync_ShouldReturnNull()
        {
            var result = await taskService.TaskInspectViewModelByIdAsync(FirstTask.Id.ToString());

            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetTasksByUserIdAndProgramId_ShouldBeEmpty()
        {
            try
            {
                var result = await taskService.GetTasksByUserIdAndProgramId(DefaultUser.Id.ToString(), DefaultUser.BetaProgramId.ToString());
            }
            catch(InvalidOperationException ex)
            {
                Assert.That(ex.GetType(), Is.EqualTo(typeof(InvalidOperationException)));
            }
        }

        [Test]
        public async Task ExistsAsync_ShouldReturnFalse()
        {
            var result = await taskService.ExistsAsync(FirstTask.Id.ToString());

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task GetTaskFormModelByIdAsync_ShouldReturnNull()
        {
            var result = await taskService.GetTaskFormModelByIdAsync(FirstTask.Id.ToString());

            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task AllByProgramIdAsync_ShouldHappen()
        {
            var result = await taskService.AllByProgramIdAsync(FacebookProgram.Id.ToString(), NewFeatureCategory.CategoryName);

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task AllByProgramIdAsync_ShouldHappenForInProgressCategory()
        {
            var result = await taskService.AllByProgramIdAsync(FacebookProgram.Id.ToString(), NewFeatureCategory.CategoryName, TaskSorting.InProgress);

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task AllByProgramIdAsync_ShouldHappenForCompletedCategory()
        {
            var result = await taskService.AllByProgramIdAsync(FacebookProgram.Id.ToString(), NewFeatureCategory.CategoryName, TaskSorting.Completed);

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task AllByProgramIdAsync_ShouldHappenForDateAscendingCategory()
        {
            var result = await taskService.AllByProgramIdAsync(FacebookProgram.Id.ToString(), NewFeatureCategory.CategoryName, TaskSorting.DateAscending);

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task AllByProgramIdAsync_ShouldHappenForDateDescendingCategory()
        {
            var result = await taskService.AllByProgramIdAsync(FacebookProgram.Id.ToString(), NewFeatureCategory.CategoryName, TaskSorting.DateDescending);

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task AllByProgramIdAsync_ShouldHappenForRewardAscendingCategory()
        {
            var result = await taskService.AllByProgramIdAsync(FacebookProgram.Id.ToString(), NewFeatureCategory.CategoryName, TaskSorting.RewardAscending);

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task AllByProgramIdAsync_ShouldHappenForRewardDescendingCategory()
        {
            var result = await taskService.AllByProgramIdAsync(FacebookProgram.Id.ToString(), NewFeatureCategory.CategoryName, TaskSorting.RewardDescending);

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task EditAsync_ShouldHappen()
        {
            const string name = "Posts issue fix";
            var model = new TaskFormModel()
            {
                Name = name,
                Description = "desc",
                Reward = 3,
                CategoryId = NewFeatureCategory.Id
            };

            await taskService.EditAsync(FirstTask.Id.ToString(), model);

            Assert.That(FirstTask.Name, Is.EqualTo(name));
        }
    }
}
