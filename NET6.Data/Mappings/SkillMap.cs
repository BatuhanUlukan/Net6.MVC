using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET6.Entity.Entities;

namespace NET6.Data.Mappings
{
    public class SkillMap : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasData(new Skill
            {
                Id = Guid.NewGuid(),
                Title = "Coder",
                Percent = "90",
                CategoryId = Guid.Parse("1BD1D873-A5FF-43E1-AA04-F86DD78495EE"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            },
            new Skill
            {
                Id = Guid.NewGuid(),
                Title = "Designer",
                Percent = "90",
                CategoryId = Guid.Parse("1266EE22-B956-4FD2-BCD1-FA55D33A77DA"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            });
        }
    }
}
