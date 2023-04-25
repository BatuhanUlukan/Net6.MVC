using AutoMapper;
using NET6.Entity.DTOs.Socials;
using NET6.Entity.Entities;

namespace NET6.Service.AutoMapper.Categories
{
    public class SocialProfile : Profile
    {
        public SocialProfile()
        {
            CreateMap<SocialDto, Social>().ReverseMap();
            CreateMap<SocialAddDto, Social>().ReverseMap();
            CreateMap<SocialUpdateDto, Social>().ReverseMap();
            CreateMap<SocialUpdateDto, SocialDto>().ReverseMap();

        }
    }
}
