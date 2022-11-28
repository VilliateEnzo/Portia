using Microsoft.AspNetCore.Identity;

namespace Portfolio.Dal.Models;

public class AppRole : IdentityRole<Guid>
{
    public ICollection<AppUserRole> UserRoles { get; set; } 
}