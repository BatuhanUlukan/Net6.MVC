using NET6.Entity.DTOs.Links;
using NET6.Entity.DTOs.Seos;
using NET6.Entity.Entities;

namespace NET6.Entity.DTOs.Abouts
{
    public class AboutDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Job { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public Image Image { get; set; }
        public AppUser User { get; set; }
        public SeoDto Seo { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
