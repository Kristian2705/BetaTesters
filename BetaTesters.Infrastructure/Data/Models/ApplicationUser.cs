using Microsoft.AspNetCore.Identity;

namespace BetaTesters.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FullName { get; set; } = string.Empty;
    }
}
