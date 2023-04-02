using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET6.Entity.Entities;

namespace NET6.Data.Mappings
{
    public class TestimonialMap : IEntityTypeConfiguration<Testimonial>
    {
        public void Configure(EntityTypeBuilder<Testimonial> builder)
        {
            builder.HasData(new Testimonial
            {
                Id = Guid.NewGuid(),
                Title = "A Firması",
                ImageId = Guid.Parse("F71F4B9A-AA60-461D-B398-DE31001BF214"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C")
            },
            new Testimonial
            {
                Id = Guid.NewGuid(),
                Title = "B Firması",
                ImageId = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            });
        }
    }
}
