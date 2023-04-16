using Microsoft.AspNetCore.Http;
using NET6.Entity.DTOs.Seos;

namespace NET6.Entity.DTOs.Abouts
{
    public class AboutAddDto
    {
        public string Title { get; set; }
        public string Job { get; set; }
        public Guid SeoId { get; set; }
        public IList<SeoDto> Seos { get; set; }
        public string Content { get; set; }
        public IFormFile Photo { get; set; }

    }
}
