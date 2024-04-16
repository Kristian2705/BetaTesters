using BetaTesters.Core.Contracts;
using BetaTesters.Core.Models.Category;
using BetaTesters.Infrastructure.Data.Common;
using BetaTesters.Infrastructure.Data.Models;

namespace BetaTesters.Core.Services
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public class CategoryService : ICategoryService
    {
        private readonly IRepository repository;

        public CategoryService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task CreateAsync(CategoryFormModel model)
        {
            var category = new Category()
            {
                CategoryName = model.Name
            };

            await repository.AddAsync(category);

            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<CategoryFormModel>> GetAllAsync()
        {
            return await repository.AllReadOnly<Category>()
                .Select(c => new CategoryFormModel()
                {
                    Name = c.CategoryName
                })
                .ToListAsync();
        }
    }
}
