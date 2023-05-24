using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using NewsSiteTurnDigital.Domain.Interfaces;
using NewsSiteTurnDigital.Domain.News;
using NewsSiteTurnDigital.Infrastructure.Repositories.News;
using NewsSiteTurnDigital.Infrastructure.Repositories.Users;
using NewsSiteTurnDigital.WEB.ViewModel;
using System.Security.Claims;
using NewsSiteTurnDigital.Domain.Users;

namespace NewsSiteTurnDigital.WEB.Services
{
    public class AdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _accessor;
        private readonly IAdminRepository _adminRepository;

        public AdminService(IUnitOfWork unitOfWork, IAdminRepository adminRepository, IHttpContextAccessor accessor)
        {
            _unitOfWork = unitOfWork;
            _adminRepository = adminRepository;
            _accessor = accessor;

        }
        public async Task<bool> SignInUser(HttpContext httpContext, AdminViewModel adminViewModel)
        {
            var isValid = await _adminRepository.GetByUserNamePassword(adminViewModel.UserName, adminViewModel.Password);
            if (isValid is null)
            {
                return false;
            }
            ClaimsIdentity identity = new ClaimsIdentity(await GetUserClaims(isValid), CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal principal = new ClaimsPrincipal(identity);

            AuthenticationProperties authenticationProperties = new AuthenticationProperties
            {
                IsPersistent = true,
            };

            await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);
            return true;
        }




        public async Task<IEnumerable<Claim>> GetUserClaims(Admin admin)
        {
            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Name, admin.Username));
            claims.Add(new Claim(ClaimTypes.Sid, admin.Id.ToString()));
            return claims;
        }

    }
}
