using NET6.Entity.DTOs.Categories;
using NET6.Entity.DTOs.Images;
using NET6.Entity.DTOs.Links;
using NET6.Entity.DTOs.Seos;
using NET6.Entity.Entities;

namespace NET6.Entity.DTOs.Portfolios
{
    public class PortfolioDto                                                      
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public SeoDto Seo { get; set; }
        public CategoryDto Category { get; set; }
        public LinkDto Links { get; set; }

        public DateTime CreatedDate { get; set; }
        public Image Image { get; set; }

        public AppUser User { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int ViewCount { get; set; }
    }
}
