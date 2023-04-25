using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET6.Entity.Entities;

namespace NET6.Data.Mappings
{
    public class SocialMap : IEntityTypeConfiguration<Social>
    {
        public void Configure(EntityTypeBuilder<Social> builder)
        {
            builder.HasData(new Social
            {
                Id = Guid.NewGuid(),
                Name = "Instagram",
                Icon = "instagram",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                LinkId = Guid.Parse("8C68D329-A387-4E55-B04E-17FCAD8CAB47"),
            },
            new Social
            {
                Id = Guid.NewGuid(),
                Name = "Google",
                Icon = "google",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                LinkId = Guid.Parse("49F708BF-48B1-4513-B8B0-0C087F6252AF"),

            });
        }
    }
}
