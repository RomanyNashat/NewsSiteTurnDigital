using System.Security.Claims;

namespace NewsSiteTurnDigital.WEB.Extensions
{
    public static class HttpContextExtension
    {
        public static string GetFullName(this HttpContext httpContext)
        {
            if (httpContext == null)
                return string.Empty;

            var claimValue = httpContext.User.Claims.SingleOrDefault(s => s.Type == ClaimTypes.Name)?.Value;
            return claimValue ?? string.Empty;
        }
        public static string GetUserID(this HttpContext httpContext)
        {
            if (httpContext == null)
                return string.Empty;

            var claimValue = httpContext.User.Claims.SingleOrDefault(s => s.Type == ClaimTypes.Sid)?.Value;
            return claimValue ?? string.Empty;
        }
    }
}
