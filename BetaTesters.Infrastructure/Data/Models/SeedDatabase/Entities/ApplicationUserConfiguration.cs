using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BetaTesters.Infrastructure.Data.Models.SeedDatabase.Entities
{
    internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
                .HasMany(au => au.Applications)
                .WithOne(a => a.Candidate);

            builder
                .HasMany(au => au.ReviewedApplications)
                .WithOne(a => a.Reviewer);

            var data = new SeedData();
            builder.HasData(new ApplicationUser[]
            {
                data.DefaultUser,
                data.Moderator,
                data.Owner
            });
        }
    }
}
