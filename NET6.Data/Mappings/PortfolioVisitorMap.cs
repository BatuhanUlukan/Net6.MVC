using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET6.Entity.Entities;

namespace NET6.Data.Mappings
{
    public class PortfolioVisitorMap : IEntityTypeConfiguration<PortfolioVisitor>
    {
        public void Configure(EntityTypeBuilder<PortfolioVisitor> builder)
        {
            builder.HasKey(x => new { x.PortfolioId, x.VisitorId });
        }
    }
}
