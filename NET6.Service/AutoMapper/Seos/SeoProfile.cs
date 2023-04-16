using AutoMapper;
using NET6.Entity.DTOs.Seos;
using NET6.Entity.Entities;

namespace NET6.Service.AutoMapper.Seos
{
    public class SeoProfile : Profile
    {
        public SeoProfile()
        {
            CreateMap<SeoDto, Seo>().ReverseMap();
            CreateMap<SeoAddDto, Seo>().ReverseMap();
            CreateMap<SeoUpdateDto, Seo>().ReverseMap();
        }
    }
}
