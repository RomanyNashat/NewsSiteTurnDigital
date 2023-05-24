using Microsoft.EntityFrameworkCore;
using NewsSiteTurnDigital.Domain.Category;
using NewsSiteTurnDigital.Domain.News;
using NewsSiteTurnDigital.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSiteTurnDigital.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<NewsCategory> NewsCategories { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<NewsItem> NewsItems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsItem>()
                .HasOne(n => n.Category)
                .WithMany()
                .HasForeignKey(n => n.CategoryId);

            modelBuilder.Entity<NewsItem>()
                .HasOne(n => n.Admin)
                .WithMany()
                .HasForeignKey(n => n.AdminId);

            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new NewsitemsConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

        }
    }
}
