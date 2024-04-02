using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BetaTesters.Data
{
    public class BetaTestersDbContext : IdentityDbContext
    {
        public BetaTestersDbContext(DbContextOptions<BetaTestersDbContext> options)
            : base(options)
        {
        }
    }
}