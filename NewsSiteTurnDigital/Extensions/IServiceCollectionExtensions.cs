using Microsoft.EntityFrameworkCore;
using NewsSiteTurnDigital.Domain.Interfaces;
using NewsSiteTurnDigital.Infrastructure;
using NewsSiteTurnDigital.Infrastructure.Repositories.Categories;
using NewsSiteTurnDigital.Infrastructure.Repositories.News;
using NewsSiteTurnDigital.Infrastructure.Repositories.Users;
using NewsSiteTurnDigital.WEB.Services;

namespace NewsSiteTurnDigital.WEB.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            // Configure DbContext with Scoped lifetime
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("NewsSiteTurnDigitalConnection"), m =>
                {
                    m.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                }
            ));

            services.AddScoped<Func<AppDbContext>>((provider) => () => provider.GetService<AppDbContext>());
            services.AddScoped<DbFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IRepository<>), typeof(Repository<>))
                .AddScoped<ICategoryRepository, CategoryRepository>()
                .AddScoped<INewsRepository, NewsRepository>()
                .AddScoped<IAdminRepository, AdminRepository>();
                //.AddScoped<ISalaryRepository, SalaryRepository>();
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
            .AddScoped<CategoryService>()
            .AddScoped<NewsService>()
            .AddScoped<AdminService>();
        }
    }
}
