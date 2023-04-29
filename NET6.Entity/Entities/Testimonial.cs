
using NET6.Core.Entities;

namespace NET6.Entity.Entities
{
    public class Testimonial : EntityBase
    {
        public Testimonial()
        {

        }
        public Testimonial(string title, Guid userId, string createdBy, Guid imageId, Guid linkId)
        {
            Title = title;
            UserId = userId;
            LinkId = linkId;
            ImageId = imageId;
            CreatedBy = createdBy;
        }

        public string Title { get; set; }

        public Guid? ImageId { get; set; }
        public Image Image { get; set; }
        public Guid LinkId { get; set; }
        public Link Link { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; }

    }
}