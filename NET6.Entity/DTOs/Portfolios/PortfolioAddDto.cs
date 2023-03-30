using Microsoft.AspNetCore.Http;

using NET6.Entity.DTOs.Categories;

namespace NET6.Entity.DTOs.Portfolios
{
    public class PortfolioAddDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }

        public IFormFile Photo { get; set; }

        public IList<CategoryDto> Categories { get; set; }
    }
}
