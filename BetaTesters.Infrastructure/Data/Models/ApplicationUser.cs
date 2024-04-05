using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static BetaTesters.Infrastructure.Constants.DataConstants;

namespace BetaTesters.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [Required]
        [MaxLength(ApplicationUserFirstNameMaxLength)]
        [PersonalData]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(ApplicationUserLastNameMaxLength)]
        [PersonalData]
        public string LastName { get; set; } = string.Empty;
    }
}
