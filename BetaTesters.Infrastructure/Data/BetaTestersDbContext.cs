using BetaTesters.Infrastructure.Data.Models;
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

        public DbSet<CandidateApplication> CandidateApplications { get; set; }

        public DbSet<BetaProgram> BetaPrograms { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Infrastructure.Data.Models.Task> Tasks { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>()
                .HasMany(au => au.Applications)
                .WithOne(a => a.Candidate);

            builder.Entity<ApplicationUser>()
                .HasMany(au => au.ReviewedApplications)
                .WithOne(a => a.Reviewer);

            base.OnModelCreating(builder);
        }
    }
}