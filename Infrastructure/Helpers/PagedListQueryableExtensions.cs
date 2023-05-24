using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSiteTurnDigital.Infrastructure.Helpers
{
    public static class PagedListQueryableExtensions
    {
        public static async Task<PagedList<T>> ToPagedListCustomAsync<T>(this IQueryable<T> source, int page, int pageSize, CancellationToken token = default)
        {
            var count = await source.CountAsync();
            if (count > 0)
            {
                var items = await source
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync(token);
                return new PagedList<T>(items, count, page, pageSize);
            }

            return new(Enumerable.Empty<T>().ToList(), 0, 0, 0);
        }

    }
}
