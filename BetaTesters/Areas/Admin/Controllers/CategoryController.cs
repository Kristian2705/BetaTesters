using BetaTesters.Core.Contracts;
using BetaTesters.Core.Models.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using static BetaTesters.Areas.Admin.AdminConstants;

namespace BetaTesters.Areas.Admin.Controllers
{
    public class CategoryController : AdminBaseController
    {
        private readonly ICategoryService categoryService;
        private readonly IMemoryCache cache;

        public CategoryController(ICategoryService _categoryService,
            IMemoryCache _cache)
        {
            categoryService = _categoryService;
            cache = _cache;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var categories = cache.
                Get<IEnumerable<CategoryFormModel>>(CategoriesCacheKey);

            if(categories == null)
            {
                categories = await categoryService.GetAllAsync();

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));

                cache.Set(CategoriesCacheKey, categories, cacheOptions);
            }

            return View(categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var category = new CategoryFormModel();

            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryFormModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            await categoryService.CreateAsync(model);

            cache.Remove(CategoriesCacheKey);

            return RedirectToAction(nameof(HomeController.Index), "Home", new { area = AreaName});
        }
    }
}
