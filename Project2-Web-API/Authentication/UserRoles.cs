using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace JWTAuthentication.Authentication
{
    [Authorize]
    public static class UserRoles
    {
        public const string Admin = "Admin";
        public const string User = "User";
    }
}
