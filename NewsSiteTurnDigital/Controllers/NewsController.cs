using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsSiteTurnDigital.WEB.Contracts;
using NewsSiteTurnDigital.WEB.Services;
using NewsSiteTurnDigital.WEB.ViewModel;
using X.PagedList;

namespace NewsSiteTurnDigital.WEB.Controllers
{
    public class NewsController : Controller
    {
        private readonly CategoryService _categoryService;
        private readonly NewsService _newsService;

        public NewsController(NewsService newsService, CategoryService categoryService)
        {
            _categoryService = categoryService;
            _newsService = newsService;
        }
        public async Task<IActionResult> Index(int? page)
        {
            var news = await _newsService.GetAllNewsItemsPaged(page ?? 1);
            var PagedNews = await _newsService.GetAllNewsItems();
            ViewBag.News = await PagedNews.ToPagedListAsync(page ?? 1, 10);
            return View(news);
        }
        public async Task<IActionResult> Details(int id)
        {
            var newsItem = await _newsService.GetNewsItemById(id);
            if (newsItem == null)
            {
                return NotFound();
            }

            return View(newsItem);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _categoryService.GetAllNewsCategory();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NewsViewModel model)

        {
            if (ModelState.IsValid)
            {
                var newsItem = await _newsService.AddNewsItemAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            int newsId = (int)id;
            var newsItem = await _newsService.GetNewsItemById(newsId);
            if (newsItem == null)
            {
                return NotFound();
            }

            NewsViewModel newsViewModel = new NewsViewModel
            {
                Id = newsItem.Id,
                CategoryId = newsItem.CategoryId,
                IsFirstPage = newsItem.IsFirstPage,
                Content = newsItem.Content,
                ImageUrl = newsItem.ImageUrl,
                Title = newsItem.Title
            };
            ViewBag.Categories = await _categoryService.GetAllNewsCategory();

            return View(newsViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, NewsViewModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var newsItem = await _newsService.EditNewsItemAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            int newsId = (int)id;
            var newsItem = await _newsService.GetNewsItemById(newsId);
            if (newsItem == null)
            {
                return NotFound();
            }

            return View(newsItem);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var newsItem = await _newsService.DeleteNewsItem(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
