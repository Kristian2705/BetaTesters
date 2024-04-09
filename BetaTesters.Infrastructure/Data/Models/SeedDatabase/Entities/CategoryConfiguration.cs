using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BetaTesters.Infrastructure.Data.Models.SeedDatabase.Entities
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var data = new SeedData();
            builder.HasData(new Category[]
            {
                data.NewFeatureCategory,
                data.BugFixCategory,
                data.CheckStateCategory
            });
        }
    }
}
