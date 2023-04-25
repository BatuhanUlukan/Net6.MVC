using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET6.Entity.Entities;

namespace NET6.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("4C569A9A-5F41-478F-9D17-69AC5B02AE0B"),
                Name = "ASP.NET Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("D23E4F79-9600-4B5E-B3E9-756CDCACD2B1"),
                Name = "Visual Studio 2022",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            }, new Category
            {
                Id = Guid.Parse("1BD1D873-A5FF-43E1-AA04-F86DD78495EE"),
                Name = "Coding",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            },
            new Category
            {
                Id = Guid.Parse("1266EE22-B956-4FD2-BCD1-FA55D33A77DA"),
                Name = "Design",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            },
            new Category
            {
                Id = Guid.Parse("2864CC7D-73FE-47B9-A5B1-BB58F6046D5C"),
                Name = "Work",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            },
            new Category
            {
                Id = Guid.Parse("53BB0F44-9F0D-447B-9A18-84722B1ABDE5"),
                Name = "Education",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
        }
    }
}