using NET6.Entity.DTOs.Articles;
using NET6.Entity.Entities;

namespace NET6.Entity.DTOs.Seos
{
    public class SeoDto
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Article Article { get; set; }

    }
}
