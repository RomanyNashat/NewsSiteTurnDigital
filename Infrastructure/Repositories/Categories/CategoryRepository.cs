using Microsoft.EntityFrameworkCore;
using NewsSiteTurnDigital.Domain.Category;
using NewsSiteTurnDigital.Domain.News;
using NewsSiteTurnDigital.Infrastructure.Repositories.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSiteTurnDigital.Infrastructure.Repositories.Categories
{
    public class CategoryRepository : Repository<NewsCategory>, ICategoryRepository
    {
        public CategoryRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }

        public NewsCategory AddCategory(NewsCategory newsCategory)
        {
            this.Add(newsCategory);
            return newsCategory;
        }

        public async Task<List<NewsCategory>> GetAllNewsCategory()
        {
            return await this.DbSet.ToListAsync();
        }

        public async Task<NewsCategory> GetById(int id)
        {
            return await this.DbSet.Where(c => c.Id == id).FirstOrDefaultAsync();
        }
    }
}
