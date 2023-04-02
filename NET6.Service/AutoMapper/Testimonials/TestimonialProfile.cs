using AutoMapper;
using NET6.Entity.DTOs.Testimonials;
using NET6.Entity.Entities;

namespace NET6.Service.AutoMapper.Testimonials
{
    public class TestimonialProfile : Profile
    {
        public TestimonialProfile()
        {
            CreateMap<TestimonialDto, Testimonial>().ReverseMap();
            CreateMap<TestimonialUpdateDto, Testimonial>().ReverseMap();
            CreateMap<TestimonialUpdateDto, TestimonialDto>().ReverseMap();
            CreateMap<TestimonialAddDto, Testimonial>().ReverseMap();
        }
    }
}
