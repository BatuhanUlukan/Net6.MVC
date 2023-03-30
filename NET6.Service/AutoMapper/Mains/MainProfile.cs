using AutoMapper;
using NET6.Entity.DTOs.Mains;
using NET6.Entity.Entities;

namespace NET6.Service.AutoMapper.Mains
{
    public class MainProfile : Profile
    {
        public MainProfile()
        {
            CreateMap<MainDto, Main>().ReverseMap();
            CreateMap<MainUpdateDto, Main>().ReverseMap();
            CreateMap<MainUpdateDto, MainDto>().ReverseMap();

        }
    }
}
