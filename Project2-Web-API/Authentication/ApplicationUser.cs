using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace JWTAuthentication.Authentication
{
    [Authorize]
    public class ApplicationUser : IdentityUser
    {
    }
}
