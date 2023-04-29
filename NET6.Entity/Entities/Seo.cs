using NET6.Core.Entities;

namespace NET6.Entity.Entities
{
    public class Seo : EntityBase
    {
        public Seo()
        {

        }
        public Seo(string author, string description, string keywords, string createdBy)
        {
            Author = author;
            Description = description;
            Keywords = keywords;
            CreatedBy = createdBy;
        }

        public string Author { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public ICollection<Article> Articles { get; set; }
        public ICollection<Portfolio> Portfolios { get; set; }
        public ICollection<About> Abouts { get; set; }



    }
}
