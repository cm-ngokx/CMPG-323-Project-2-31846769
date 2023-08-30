using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace JWTAuthentication.Authentication
{
    [Authorize]
    public class Response
    {
        public string? Status { get; set; }
        public string? Message { get; set; }
    }
}
