using NET6.Core.Entities;

namespace NET6.Entity.Entities
{
    public class Process : EntityBase
    {
        public Process()
        {

        }
        public Process(string title, string content, Guid userId, string createdBy, Guid imageId)
        {
            Title = title;
            Content = content;
            UserId = userId;
            ImageId = imageId;
            CreatedBy = createdBy;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public Guid? ImageId { get; set; }
        public Image Image { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
