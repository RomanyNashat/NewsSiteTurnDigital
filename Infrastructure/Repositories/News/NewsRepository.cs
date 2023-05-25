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
    public class NewsRepository : Repository<NewsItem>, INewsRepository
    {
        public NewsRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
        public IQueryable<NewsItem> GetAllNewsItemsIQueryable()
        {
            return DbSet.AsQueryable();
        }
        public async Task<List<NewsItem>> GetAllNewsItems()
        {
            return await DbSet.Where(x => x.IsDeleted != true).ToListAsync();
        }
        public async Task<IPagedList<NewsItem>> GetAllNewsItemsPaged(int page, int pageSize)
        {
            return await DbSet.Where(x => x.IsDeleted != true).ToPagedListAsync(page, pageSize);
        }
        public async Task<NewsItem> GetNewsItemById(int Id)
        {
            return await DbSet.Where(s => s.Id == Id & s.IsDeleted != true).FirstOrDefaultAsync();
        }
        public NewsItem AddNewsItem(NewsItem newsItem)
        {
            Add(newsItem);
            return newsItem;
        }
        public NewsItem EditNewsItem(NewsItem newsItem)
        {
            Update(newsItem);
            return newsItem;
        }
        public NewsItem DeleteNewsItem(NewsItem newsItem)
        {
            Delete(newsItem);
            return newsItem;
        }

    }
}
