using Microsoft.AspNetCore.Http;
using NET6.Entity.DTOs.Links;
using NET6.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Entity.DTOs.Testimonials
{
    public class TestimonialUpdateDto
    {

            public Guid Id { get; set; }
            public string Title { get; set; }
            public Image Image { get; set; }
            public IFormFile? Photo { get; set; }
            public Guid LinkId { get; set; }
            public IList<LinkDto> Links { get; set; }

       
    }
}
