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
    }
}