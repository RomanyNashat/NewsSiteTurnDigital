using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NewsSiteTurnDigital.WEB.Services;
using X.PagedList;

namespace NewsSiteTurnDigital.WEB.API
{
    //[Route("api/[controller]")]
    [ApiController]
    public class NewsAPIController : ControllerBase
    {
        private readonly NewsService _newsService;

        public NewsAPIController(NewsService newsService)
        {
            _newsService = newsService;
        }
        [HttpGet("News/All")]
        public async Task<IActionResult> AllNews()
        {
            var allNews = await _newsService.GetAllNewsItems();
            return Ok(allNews);
        }
        [HttpGet("News/AllById/{id}")]
        public async Task<IActionResult> AllNewsById(int id)
        {
            var newsItem = await _newsService.GetNewsItemById(id);
            return Ok(newsItem);
        }

    }
}
