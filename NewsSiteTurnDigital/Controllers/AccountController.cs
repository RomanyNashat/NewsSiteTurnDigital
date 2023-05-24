using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsSiteTurnDigital.WEB.Services;
using NewsSiteTurnDigital.WEB.ViewModel;

namespace NewsSiteTurnDigital.WEB.Controllers
{
    public class AccountController : Controller
    {
        private readonly AdminService _signInManger;
        private readonly IHttpContextAccessor _accessor;

        public AccountController(AdminService signInManger, IHttpContextAccessor accessor)
        {
            this._signInManger = signInManger;
            this._accessor = accessor;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(AdminViewModel dto)
        {


            var signedInUser = await _signInManger.SignInUser(HttpContext, dto);
            if (!signedInUser)
            {
                ViewBag.invalid = "User not Found";
                return View(dto);
            }
            return RedirectToAction("Index", "News");
        }
    }
}
