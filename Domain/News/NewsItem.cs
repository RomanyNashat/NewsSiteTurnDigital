using NewsSiteTurnDigital.Domain.Base;
using NewsSiteTurnDigital.Domain.Category;
using NewsSiteTurnDigital.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSiteTurnDigital.Domain.News
{
    public class NewsItem : AuditEntity<int>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public int AdminId { get; set; }
        public string ImageUrl { get; set; }

        public bool IsFirstPage { get; set; }

        public NewsCategory Category { get; set; }
        public Admin Admin { get; set; }
    }
}
