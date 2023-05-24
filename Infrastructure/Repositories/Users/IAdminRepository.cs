using NewsSiteTurnDigital.Domain.Interfaces;
using NewsSiteTurnDigital.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSiteTurnDigital.Infrastructure.Repositories.Users
{
    public interface IAdminRepository : IRepository<Admin>
    {
        Task<Admin> GetByUserNamePassword(string UserName, string Password);
    }
}
