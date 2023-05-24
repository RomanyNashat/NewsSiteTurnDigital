using NewsSiteTurnDigital.Domain.Category;
using NewsSiteTurnDigital.Domain.News;
using NewsSiteTurnDigital.Infrastructure.Helpers;
using X.PagedList;

namespace NewsSiteTurnDigital.WEB.ViewModel
{
    public class HomeViewModel
    {
        public List<NewsItem> FirstPageNews { get; set; }
        public List<NewsItem> FirstNews { get; set; }
        public List<NewsItem> AllNews { get; set; }
        public List<NewsCategory> NewsCategories { get; set; }

    }
}
