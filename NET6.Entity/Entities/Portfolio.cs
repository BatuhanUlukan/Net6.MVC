
using NET6.Core.Entities;
using NET6.Entity.DTOs.Seos;

namespace NET6.Entity.Entities
{
    public class Portfolio : EntityBase
    {
        public Portfolio()
        {

        }
        public Portfolio(string title, string content, Guid userId, string createdBy, Guid categoryId, Guid imageId, Guid seoId)
        {
            Title = title;
            Content = content;
            UserId = userId;
            CategoryId = categoryId;
            ImageId = imageId;
            SeoId = seoId;
            CreatedBy = createdBy;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; } = 0;
        public Guid SeoId { get; set; }
        public Seo Seo { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid? ImageId { get; set; }
        public Image Image { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }

    }
}