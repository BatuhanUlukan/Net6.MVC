using Microsoft.AspNetCore.Http;
using NET6.Entity.DTOs.Categories;
using NET6.Entity.DTOs.Seos;

namespace NET6.Entity.DTOs.Articles
{
    public class ArticleAddDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public IFormFile Photo { get; set; }
        public Guid CategoryId { get; set; }
        public Guid SeoId { get; set; }

        public IList<SeoDto> Seos { get; set; }
        public IList<CategoryDto> Categories { get; set; }


    }
}
