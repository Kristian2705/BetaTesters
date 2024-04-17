using BetaTesters.Infrastructure.Data.Models;
using BetaTesters.Infrastructure.Data.Models.SeedDatabase.Configurations.Entities;
using BetaTesters.Infrastructure.Data.Models.SeedDatabase.Configurations.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BetaTesters.Data
{
    public class BetaTestersDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public BetaTestersDbContext(DbContextOptions<BetaTestersDbContext> options, bool seedDb)
            : base(options)
        {
            //if (Database.IsRelational())
            //{
            //    Database.Migrate();
            //}
            //else
            //{
            //    Database.EnsureCreated();
            //}

            //_seedDb = seedDb;
        }

        public DbSet<CandidateApplication> CandidateApplications { get; set; } = null!;

        public DbSet<BetaProgram> BetaPrograms { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Payment> Payments { get; set; } = null!;

        public DbSet<Infrastructure.Data.Models.Task> Tasks { get; set; } = null!;

        public DbSet<Transaction> Transactions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new BetaProgramConfiguration());
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new IdentityUserClaimConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new TaskConfiguration());

            base.OnModelCreating(builder);
        }
    }
}