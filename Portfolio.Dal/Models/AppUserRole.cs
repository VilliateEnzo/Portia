using Microsoft.AspNetCore.Identity;

namespace Portfolio.Dal.Models;

public class AppUserRole : IdentityUserRole<Guid>
{
    public AppUser user { get; set; }
    
    public AppRole Role { get; set; }
}