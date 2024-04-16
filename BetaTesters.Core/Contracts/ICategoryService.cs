using BetaTesters.Core.Models.Category;

namespace BetaTesters.Core.Contracts
{
    public interface ICategoryService
    {
        Task CreateAsync(CategoryFormModel model);

        Task<IEnumerable<CategoryFormModel>> GetAllAsync();
    }
}
