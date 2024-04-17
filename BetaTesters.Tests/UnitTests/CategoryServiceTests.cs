using BetaTesters.Core.Contracts;
using BetaTesters.Core.Services;
using BetaTesters.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetaTesters.Core.Models.Category;

namespace BetaTesters.Tests.UnitTests
{
    using System.Threading.Tasks;

    [TestFixture]
    public class CategoryServiceTests : UnitTestsBase
    {
        private ICategoryService categoryService;

        [OneTimeSetUp]
        public void SetUp()
        {
            categoryService = new CategoryService(repository);
        }

        [Test]
        public async Task GetAllAsync_ReturnsEmpty()
        {
            var result = await categoryService.GetAllAsync();

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task CreateAsync_ShouldFail()
        {
            await categoryService.CreateAsync(new CategoryFormModel
            {
                Name = "name"
            });

            Assert.That(repository.AllReadOnly<Category>().Count(), Is.EqualTo(1));
        }
    }
}
