using NET6.Entity.DTOs.Links;
using NET6.Entity.Entities;

namespace NET6.Entity.DTOs.Testimonials
{
    public class TestimonialDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public LinkDto Link { get; set; }

        public Image Image { get; set; }
        public AppUser User { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
