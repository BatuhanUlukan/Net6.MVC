using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET6.Entity.Entities;

namespace NET6.Data.Mappings
{
    public class LinkMap : IEntityTypeConfiguration<Link>
    {
        public void Configure(EntityTypeBuilder<Link> builder)
        {
            builder.HasData(new Link
            {
                Id = Guid.Parse("8C68D329-A387-4E55-B04E-17FCAD8CAB47"),
                Name = "Instagram",
                Url = "www.instagram.com",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Link
            {
                Id = Guid.Parse("49F708BF-48B1-4513-B8B0-0C087F6252AF"),
                Name = "Google",
                Url = "www.google.com",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false


            });

        }
    }
}
