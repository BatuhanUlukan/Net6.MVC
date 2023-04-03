using NET6.Core.Entities;

namespace NET6.Entity.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {

        }
        public Category(string name, string createdBy)
        {
            Name = name;
            CreatedBy = createdBy;
        }
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
        public ICollection<Portfolio> Portfolios { get; set; }
        public ICollection<History> Histories { get; set; }
        public ICollection<Skill> Skills { get; set; }
    }
}
