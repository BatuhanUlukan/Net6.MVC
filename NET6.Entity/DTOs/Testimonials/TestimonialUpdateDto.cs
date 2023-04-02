﻿using Microsoft.AspNetCore.Http;

using NET6.Entity.Entities;

namespace NET6.Entity.DTOs.Testimonials
{
    public class TestimonialUpdateDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Image Image { get; set; }
        public IFormFile? Photo { get; set; }

    }
}
