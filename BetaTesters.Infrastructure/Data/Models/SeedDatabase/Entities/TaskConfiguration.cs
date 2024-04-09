using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BetaTesters.Infrastructure.Data.Models.SeedDatabase.Entities
{
    internal class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            var data = new SeedData();
            builder.HasData(new Task[]
            {
                data.FirstTask,
                data.SecondTask,
                data.ThirdTask
            });
        }
    }
}
