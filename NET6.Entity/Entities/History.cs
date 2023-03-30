using NET6.Core.Entities;

namespace NET6.Entity.Entities
{
    public class History : EntityBase
    {
        public History()
        {

        }
        public History(string title, string name, string content, string sfdate, string createdBy, Guid userId, Guid categoryId)
        {
            Title = title;
            Name = name;
            Content = content;
            SFDate = sfdate;
            UserId = userId;
            CategoryId = categoryId;
            CreatedBy = createdBy;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Name { get; set; }
        public string SFDate { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; }


    }
}