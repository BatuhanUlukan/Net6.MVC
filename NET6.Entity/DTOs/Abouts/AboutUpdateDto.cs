using Microsoft.AspNetCore.Http;
using NET6.Entity.DTOs.Links;
using NET6.Entity.DTOs.Seos;
using NET6.Entity.Entities;

namespace NET6.Entity.DTOs.Abouts
{
    public class AboutUpdateDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Job { get; set; }
        public string Content { get; set; }
        public Image Image { get; set; }
        public IFormFile? Photo { get; set; }
        public Guid SeoId { get; set; }
        public Guid LinkId { get; set; }
        public IList<LinkDto> Links { get; set; }
        public IList<SeoDto> Seos { get; set; }


    }
}
