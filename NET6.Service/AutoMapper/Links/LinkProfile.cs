using AutoMapper;
using NET6.Entity.DTOs.Links;
using NET6.Entity.Entities;

namespace NET6.Service.AutoMapper.Categories
{
    public class LinkProfile : Profile
    {
        public LinkProfile()
        {
            CreateMap<LinkDto, Link>().ReverseMap();
            CreateMap<LinkAddDto, Link>().ReverseMap();
            CreateMap<LinkUpdateDto, Link>().ReverseMap();
            CreateMap<LinkUpdateDto, LinkDto>().ReverseMap();

        }
    }
}
