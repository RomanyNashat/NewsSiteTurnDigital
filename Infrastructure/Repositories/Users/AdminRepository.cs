using Microsoft.EntityFrameworkCore;
using NewsSiteTurnDigital.Domain.Category;
using NewsSiteTurnDigital.Domain.Interfaces;
using NewsSiteTurnDigital.Domain.Users;
using NewsSiteTurnDigital.Infrastructure.Repositories.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSiteTurnDigital.Infrastructure.Repositories.Users
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        public AdminRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

        public async Task<Admin> GetByUserNamePassword(string UserName, string Password)
        {
            var admin = await this.DbSet.Where(c => c.Username == UserName && c.Password == Password).FirstOrDefaultAsync();
            return admin;
        }
    }
}
