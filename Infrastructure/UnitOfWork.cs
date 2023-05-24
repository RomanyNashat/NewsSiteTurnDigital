using NewsSiteTurnDigital.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSiteTurnDigital.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbFactory _dbFactory;

        public UnitOfWork(DbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public Task<int> CommitAsync()
        {
            return _dbFactory.DbContext.SaveChangesAsync();
        }
    }
}
