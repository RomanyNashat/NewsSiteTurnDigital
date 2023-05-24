using NewsSiteTurnDigital.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSiteTurnDigital.Domain.Category
{
    public class NewsCategory : AuditEntity<int>
    {
        public string Name { get; set; }
    }
}
