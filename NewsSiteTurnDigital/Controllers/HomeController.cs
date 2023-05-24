using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsSiteTurnDigital.WEB.Contracts;
using NewsSiteTurnDigital.WEB.Models;
using NewsSiteTurnDigital.WEB.Services;
using NewsSiteTurnDigital.WEB.ViewModel;
using System.Diagnostics;

namespace NewsSiteTurnDigital.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CategoryService _categoryService;
        private readonly NewsService _newsService;

        public HomeController(ILogger<HomeController> logger, NewsService newsService, CategoryService categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _newsService = newsService;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index(int page = 1)
        {
            var homeViewModel = new HomeViewModel
            {
                FirstPageNews = await _newsService.GetAllNewsItemsByExprission(x => x.IsFirstPage),
                FirstNews = await _newsService.GetAllNewsItems(),
                AllNews = await _newsService.GetAllNewsItems(),
                NewsCategories = await _categoryService.GetAllNewsCategory(),
            };
            ViewBag.Index = homeViewModel;

            return View();
        }
    }
}