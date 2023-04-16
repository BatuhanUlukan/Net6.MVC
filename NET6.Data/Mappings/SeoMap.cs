using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET6.Entity.Entities;

namespace NET6.Data.Mappings
{
    public class SeoMap : IEntityTypeConfiguration<Seo>
    {
        public void Configure(EntityTypeBuilder<Seo> builder)
        {
            builder.HasData(new Seo
            {
                Id = Guid.Parse("59D9A438-3E21-4163-A42D-A13003D76831"),
                Author = "ASP.NET Core",
                Description = "ASP.NET Core",
                Keywords = "ASP.NET Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Seo
            {
                Id = Guid.Parse("a7f5670d-31eb-4eea-ba51-a5e924135542"),
                Author = "ASP.NET Core",
                Description = "ASP.NET Core",
                Keywords = "ASP.NET Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            }
            );
        }
    }
}