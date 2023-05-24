using NewsSiteTurnDigital.Domain.Category;
using NewsSiteTurnDigital.Domain.Interfaces;
using NewsSiteTurnDigital.Domain.News;
using NewsSiteTurnDigital.Infrastructure.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSiteTurnDigital.Infrastructure.Repositories.Categories
{
    public interface ICategoryRepository : IRepository<NewsCategory>
    {
        Task<List<NewsCategory>> GetAllNewsCategory();
        Task<NewsCategory> GetById(int id);
        NewsCategory AddCategory(NewsCategory newsCategory);
    }
}
