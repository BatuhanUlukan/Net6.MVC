using Microsoft.AspNetCore.Http;
using NET6.Entity.DTOs.Links;

namespace NET6.Entity.DTOs.Testimonials

{
    public class TestimonialAddDto
    {
        public string Title { get; set; }
        public IFormFile Photo { get; set; }
        public Guid LinkId { get; set; }
        public IList<LinkDto> Links { get; set; }

    }
}
