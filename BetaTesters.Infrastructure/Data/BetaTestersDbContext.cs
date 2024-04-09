using BetaTesters.Infrastructure.Data.Models;
using BetaTesters.Infrastructure.Data.Models.SeedDatabase.Entities;
using BetaTesters.Infrastructure.Data.Models.SeedDatabase.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BetaTesters.Data
{
    public class BetaTestersDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public BetaTestersDbContext(DbContextOptions<BetaTestersDbContext> options)
            : base(options)
        {
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
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new IdentityUserClaimConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new BetaProgramConfiguration());
            builder.ApplyConfiguration(new TaskConfiguration());

            base.OnModelCreating(builder);
        }
    }
}