
using NET6.Core.Entities;

namespace NET6.Entity.Entities
{
    public class Testimonial : EntityBase
    {
        public Testimonial()
        {

        }
        public Testimonial(string title, Guid userId, string createdBy, Guid imageId)
        {
            Title = title;
            UserId = userId;
            ImageId = imageId;
            CreatedBy = createdBy;
        }

        public string Title { get; set; }

        public Guid? ImageId { get; set; }
        public Image Image { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; }

    }
}