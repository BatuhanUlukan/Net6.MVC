using Microsoft.AspNetCore.Identity;
using NET6.Core.Entities;

namespace NET6.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>, IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid ImageId { get; set; } = Guid.Parse("4084c97a-2aa1-4675-b519-69f6fe410633");
        public Image Image { get; set; }

        public ICollection<Article> Articles { get; set; }
        public ICollection<Portfolio> Portfolios { get; set; }
        public ICollection<History> Histories { get; set; }
        public ICollection<About> Abouts { get; set; }
        public ICollection<Testimonial> Testimonials { get; set; }
        public ICollection<Process> Processes { get; set; }

    }
}
