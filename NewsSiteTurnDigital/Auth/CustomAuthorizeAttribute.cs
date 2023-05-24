using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace NewsSiteTurnDigital.WEB.Auth
{
    public class CustomAuthorizeAttribute : IAuthorizationFilter
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CustomAuthorizeAttribute(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var httpContext = _httpContextAccessor.HttpContext;

            // Check if user is authenticated

            if (!httpContext.User.Identity.IsAuthenticated)
            {
                context.Result = new UnauthorizedResult();
                return;
            }
        }

    }
}
