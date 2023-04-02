using AutoMapper;

using NET6.Entity.DTOs.Abouts;
using NET6.Entity.Entities;

namespace NET6.Service.AutoMapper.Abouts
{
    public class AboutProfile : Profile
    {
        public AboutProfile()
        {
            CreateMap<AboutDto, About>().ReverseMap();
            CreateMap<AboutUpdateDto, About>().ReverseMap();
            CreateMap<AboutUpdateDto, AboutDto>().ReverseMap();
            CreateMap<AboutAddDto, About>().ReverseMap();

        }
    }
}
