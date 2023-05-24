using Microsoft.EntityFrameworkCore;
using NewsSiteTurnDigital.Domain.Interfaces;
using NewsSiteTurnDigital.Domain.News;
using NewsSiteTurnDigital.Infrastructure.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace NewsSiteTurnDigital.Infrastructure.Repositories.News
{
    public interface INewsRepository : IRepository<NewsItem>
    {
        IQueryable<NewsItem> GetAllNewsItemsIQueryable();
        Task<List<NewsItem>> GetAllNewsItems();
        Task<IPagedList<NewsItem>> GetAllNewsItemsPaged(int page, int pageSize);
        Task<NewsItem> GetNewsItemById(int Id);
        NewsItem AddNewsItem(NewsItem newsItem);
        NewsItem EditNewsItem(NewsItem newsItem);
        NewsItem DeleteNewsItem(NewsItem newsItem);
    }
}