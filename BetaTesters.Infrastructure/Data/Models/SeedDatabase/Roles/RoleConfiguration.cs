using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BetaTesters.Infrastructure.Data.Models.SeedDatabase.Roles
{
    internal class RoleConfiguration : IEntityTypeConfiguration<IdentityRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
        {
            var data = new SeedData();
            builder.HasData(data.Roles);
        }
    }
}
