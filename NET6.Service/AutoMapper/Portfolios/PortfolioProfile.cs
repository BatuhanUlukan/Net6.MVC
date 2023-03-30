using AutoMapper;
using NET6.Entity.Entities;
using NET6.Entity.DTOs.Portfolios;

namespace NET6.Service.AutoMapper.Portfolios
{
    public class PortfolioProfile : Profile
    {
        public PortfolioProfile()
        {
            CreateMap<PortfolioDto, Portfolio>().ReverseMap();
            CreateMap<PortfolioUpdateDto, Portfolio>().ReverseMap();
            CreateMap<PortfolioUpdateDto, PortfolioDto>().ReverseMap();
            CreateMap<PortfolioAddDto, Portfolio>().ReverseMap();
        }
    }
}
