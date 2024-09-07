using Microsoft.AspNetCore.Identity;

namespace BookBarn.UserAuthentication.Service
{
    public interface ITokenService
    {
        public Task<string> GenerateToken(IdentityUser user);
    }
}
