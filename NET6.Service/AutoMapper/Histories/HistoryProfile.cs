using AutoMapper;
using NET6.Entity.DTOs.Histories;
using NET6.Entity.Entities;

namespace NET6.Service.AutoMapper.Histories
{
    public class HistoryProfile : Profile
    {
        public HistoryProfile()
        {
            CreateMap<HistoryDto, History>().ReverseMap();
            CreateMap<HistoryUpdateDto, History>().ReverseMap();
            CreateMap<HistoryUpdateDto, HistoryDto>().ReverseMap();
            CreateMap<HistoryAddDto, History>().ReverseMap();
        }
    }
}
