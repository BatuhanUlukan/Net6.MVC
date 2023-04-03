using AutoMapper;

using NET6.Entity.DTOs.Skills;
using NET6.Entity.Entities;

namespace NET6.Service.AutoMapper.Skills
{
    public class SkillProfile : Profile
    {
        public SkillProfile()
        {
            CreateMap<SkillDto, Skill>().ReverseMap();
            CreateMap<SkillUpdateDto, Skill>().ReverseMap();
            CreateMap<SkillUpdateDto, SkillDto>().ReverseMap();
            CreateMap<SkillAddDto, Skill>().ReverseMap();

        }
    }
}
