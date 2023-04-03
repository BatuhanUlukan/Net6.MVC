using AutoMapper;
using NET6.Entity.Entities;
using NET6.Entity.DTOs.Processes;

namespace NET6.Service.AutoMapper.Processes
{
    public class ProcessesProfile : Profile
    {
        public ProcessesProfile()
        {
            CreateMap<ProcessDto, Process>().ReverseMap();
            CreateMap<ProcessUpdateDto, Process>().ReverseMap();
            CreateMap<ProcessUpdateDto, ProcessDto>().ReverseMap();
            CreateMap<ProcessAddDto, Process>().ReverseMap();
        }
    }
}
