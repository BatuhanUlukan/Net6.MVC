using NET6.Entity.Entities;

namespace NET6.Entity.DTOs.Testimonials
{
    public class TestimonialListDto
    {
        public IList<Testimonial> Testimonials { get; set; }
        public Image Image { get; set; }
        public virtual bool IsAscending { get; set; } = false;
    }
}
