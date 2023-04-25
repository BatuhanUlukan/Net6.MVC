using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET6.Entity.Entities;

namespace NET6.Data.Mappings
{
    public class ProcessMap : IEntityTypeConfiguration<Process>
    {
        public void Configure(EntityTypeBuilder<Process> builder)
        {
            builder.HasData(new About
            {
                Id = Guid.NewGuid(),
                Title = "Batuhan Ulukan",
                Content = "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Nulla porttitor accumsan tincidunt.",
                ImageId = Guid.Parse("F71F4B9A-AA60-461D-B398-DE31001BF214"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            });
        }
    }
}
