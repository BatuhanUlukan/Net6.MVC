
using NET6.Core.Entities;

namespace NET6.Entity.Entities
{
    public class About : EntityBase
    {
        public About()
        {

        }
        public About(string title, string content, string job, Guid userId, string createdBy, Guid imageId, Guid seoId)
        {
            Title = title;
            Content = content;
            Job = job;
            UserId = userId;
            ImageId = imageId;
            SeoId = seoId;
            CreatedBy = createdBy;

        }

        public string Title { get; set; }

        public string Content { get; set; }
        public string Job { get; set; }

        public Guid? ImageId { get; set; }
        public Image Image { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; }

        public Guid SeoId { get; set; }
        public Seo Seo { get; set; }

    }
}