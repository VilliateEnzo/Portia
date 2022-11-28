using Portfolio.Dal.Models;

namespace Portfolio.Bll.Interfaces;

public interface ITokenService
{
    string createToken(AppUser user);
}
