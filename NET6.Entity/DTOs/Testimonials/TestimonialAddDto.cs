using Microsoft.AspNetCore.Http;

namespace NET6.Entity.DTOs.Testimonials

{
    public class TestimonialAddDto
    {
        public string Title { get; set; }
        public IFormFile Photo { get; set; }

    }
}
