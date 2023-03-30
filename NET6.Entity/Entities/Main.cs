using NET6.Core.Entities;

namespace NET6.Entity.Entities
{
    public class Main : EntityBase
    {
        public Main()
        {

        }
        public Main(string name, string title, string content, string createdBy, Guid imageId, Guid userId)
        {
            Job = name;
            Title = title;
            Content = content;
            ImageId = imageId;
            UserId = userId;
            CreatedBy = createdBy;

        }
        public string Job { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid? ImageId { get; set; }
        public Image Image { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
