using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsSiteTurnDigital.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSiteTurnDigital.Domain.Category
{
    public class CategoryConfiguration : IEntityTypeConfiguration<NewsCategory>
    {
        public void Configure(EntityTypeBuilder<NewsCategory> builder)
        {
            builder.HasData(new NewsCategory
            {
                Id= 1,
                Name = "Health",
                CreatedDate= DateTime.Now,
                CreatedBy= "TurnDigital",
                IsDeleted= false,
            },new NewsCategory
            {
                Id= 2,
                Name = "Tech",
                CreatedDate= DateTime.Now,
                CreatedBy= "TurnDigital",
                IsDeleted= false,
            },new NewsCategory
            {
                Id= 3,
                Name = "Fashion",
                CreatedDate= DateTime.Now,
                CreatedBy= "TurnDigital",
                IsDeleted= false,
            },new NewsCategory
            {
                Id= 4,
                Name = "Sport",
                CreatedDate= DateTime.Now,
                CreatedBy= "TurnDigital",
                IsDeleted= false,
            });
        }
    }
}
