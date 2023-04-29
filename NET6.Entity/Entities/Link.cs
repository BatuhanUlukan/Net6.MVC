using NET6.Core.Entities;

namespace NET6.Entity.Entities
{
    public class Link : EntityBase
    {
        public Link()
        {

        }
        public Link(string name, string url, string createdBy)
        {
            Name = name;
            Url = url;
            CreatedBy = createdBy;
        }

        public string Name { get; set; }
        public string Url { get; set; }
        public ICollection<Social> Socials { get; set; }
        public ICollection<Testimonial> Testimonials { get; set; }
        public ICollection<Portfolio> Portfolios { get; set; }

    }
}
