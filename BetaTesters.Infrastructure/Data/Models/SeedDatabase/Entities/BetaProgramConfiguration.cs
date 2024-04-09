using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BetaTesters.Infrastructure.Data.Models.SeedDatabase.Entities
{
    internal class BetaProgramConfiguration : IEntityTypeConfiguration<BetaProgram>
    {
        public void Configure(EntityTypeBuilder<BetaProgram> builder)
        {
            var data = new SeedData();
            builder.HasData(data.FacebookProgram);
        }
    }
}
