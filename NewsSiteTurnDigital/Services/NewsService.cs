using Microsoft.EntityFrameworkCore;
using NewsSiteTurnDigital.Domain.Interfaces;
using NewsSiteTurnDigital.Domain.News;
using NewsSiteTurnDigital.Infrastructure.Helpers;
using NewsSiteTurnDigital.Infrastructure.Repositories.News;
using NewsSiteTurnDigital.WEB.Contracts;
using NewsSiteTurnDigital.WEB.Extensions;
using NewsSiteTurnDigital.WEB.ViewModel;
using System.Linq;
using System.Linq.Expressions;
using X.PagedList;

namespace NewsSiteTurnDigital.WEB.Services
{
    public class NewsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly INewsRepository _newsRepository;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _hosting;
        private readonly IHttpContextAccessor _accessor;

        public NewsService(IUnitOfWork unitOfWork
        , INewsRepository newsRepository,
Microsoft.AspNetCore.Hosting.IHostingEnvironment hosting,
IHttpContextAccessor accessor)
        {
            _unitOfWork = unitOfWork;
            _newsRepository = newsRepository;
            _hosting = hosting;
            _accessor = accessor;
        }
        public async Task<NewsItem> AddNewsItemAsync(NewsViewModel newsItem)
        {
            var item = new NewsItem()
            {
                ImageUrl = newsItem.File.FileName,
                IsFirstPage = newsItem.IsFirstPage,
                CategoryId = newsItem.CategoryId,
                Title = newsItem.Title,
                AdminId = Convert.ToInt32(_accessor.HttpContext.GetUserID()),
                Content = newsItem.Content,
                CreatedDate = DateTime.Now,
                CreatedBy = _accessor.HttpContext.GetFullName()
            };
            var newItem = _newsRepository.AddNewsItem(item);
            await _unitOfWork.CommitAsync();
            if (newsItem.File != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\News");
                string fullPath = Path.Combine(uploads, newsItem.File.FileName);
                newsItem.File.CopyTo(new FileStream(fullPath, FileMode.Create));
            }

            return newItem;
        }
        public async Task<NewsItem> EditNewsItemAsync(NewsViewModel newsItem)
        {
            var NewsItembyId = await _newsRepository.GetNewsItemById(newsItem.Id);
            NewsItembyId.Title = newsItem.Title;
            NewsItembyId.CategoryId = newsItem.CategoryId;
            NewsItembyId.IsFirstPage = newsItem.IsFirstPage;
            NewsItembyId.Content = newsItem.Content;
            NewsItembyId.UpdatedDate = DateTime.Now;
            NewsItembyId.UpdatedBy = _accessor.HttpContext.GetFullName();

            if (newsItem.File != null)
            {
                string uploads = Path.Combine(_hosting.WebRootPath, @"img\News");
                string fullPath = Path.Combine(uploads, newsItem.File.FileName);
                newsItem.File.CopyTo(new FileStream(fullPath, FileMode.Create));
                NewsItembyId.ImageUrl = newsItem.File.FileName;

            }

            var item = _newsRepository.EditNewsItem(NewsItembyId);
            await _unitOfWork.CommitAsync();

            return NewsItembyId;
        }
        public async Task<NewsItem> DeleteNewsItem(int id)
        {

            var NewsItems = await _newsRepository.GetNewsItemById(id);

            var item = _newsRepository.DeleteNewsItem(NewsItems);
            await _unitOfWork.CommitAsync();
            return NewsItems;
        }
        public async Task<List<NewsItem>> GetAllNewsItems()
        {
            var NewsItems = await _newsRepository.GetAllNewsItems();
            return NewsItems;

        }
        public async Task<List<NewsItem>> GetAllNewsItemsPaged(int? page)
        {
            var NewsItems = _newsRepository.GetAllNewsItemsIQueryable();
            var skippage = (page ?? 1) - 1;
            var skip = skippage * 10;
            var newsPaged = await NewsItems.Skip(skip).Take(10).ToListAsync();
            return newsPaged;
        }
        public async Task<IPagedList<NewsItem>> GetAllNewsItemsPagesByExprission(Expression<Func<NewsItem, bool>> expression, int page, int pageSize = 10)
        {
            var NewsItemsWithExpression = _newsRepository.List(expression);
            var NewsItems = await NewsItemsWithExpression.ToPagedListAsync(page, pageSize);
            return NewsItems;
        }
        public async Task<List<NewsItem>> GetAllNewsItemsByExprission(Expression<Func<NewsItem, bool>> expression)
        {
            var NewsItemsWithExpression = await _newsRepository.List(expression).ToListAsync();
            return NewsItemsWithExpression;
        }
        public async Task<NewsItem> GetNewsItemById(int Id)
        {
            var NewsItems = await _newsRepository.GetNewsItemById(Id);
            return NewsItems;
        }

    }


}
