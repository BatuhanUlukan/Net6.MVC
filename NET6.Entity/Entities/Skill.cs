using NET6.Core.Entities;

namespace NET6.Entity.Entities
{
    public class Skill : EntityBase
    {
        public Skill()
        {

        }
        public Skill(string title, string percent, string createdBy, Guid userId, Guid categoryId)
        {
            Title = title;
            Percent = percent;
            UserId = userId;
            CategoryId = categoryId;
            CreatedBy = createdBy;
        }

        public string Title { get; set; }
        public string Percent { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; }


    }
}