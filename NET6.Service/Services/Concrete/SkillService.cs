using AutoMapper;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using NET6.Data.UnitOfWorks;
using NET6.Entity.DTOs.Skills;
using NET6.Entity.Entities;
using NET6.Service.Extensions;
using NET6.Service.Services.Abstractions;
using NET6.Data.Migrations;
using NET6.Entity.DTOs.Processes;

namespace NET6.Service.Services.Concrete
{
    public class SkillService : ISkillService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ClaimsPrincipal _user;

        public SkillService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
        }

        public async Task CreateSkillAsync(SkillAddDto skillAddDto)
        {

            var userId = _user.GetLoggedInUserId();
            var userEmail = _user.GetLoggedInEmail();


            var skill = new Skill(skillAddDto.Title, skillAddDto.Percent, userEmail, userId,skillAddDto.CategoryId);


            await unitOfWork.GetRepository<Skill>().AddAsync(skill);
            await unitOfWork.SaveAsync();
        }

        public async Task<List<SkillDto>> GetAllSkillsWithCategoryNonDeletedAsync()
        {

            var skills = await unitOfWork.GetRepository<Skill>().GetAllAsync(x => !x.IsDeleted, x => x.Category);
            var map = mapper.Map<List<SkillDto>>(skills);

            return map;
        }
        public async Task<SkillDto> GetSkillWithCategoryNonDeletedAsync(Guid skillId)
        {

            var skill = await unitOfWork.GetRepository<Skill>().GetAsync(x => !x.IsDeleted && x.Id == skillId, x => x.Category, u => u.User);
            var map = mapper.Map<SkillDto>(skill);

            return map;
        }
        public async Task<string> UpdateSkillAsync(SkillUpdateDto skillUpdateDto)
        {
            var userEmail = _user.GetLoggedInEmail();
            var skill = await unitOfWork.GetRepository<Skill>().GetAsync(x => !x.IsDeleted && x.Id == skillUpdateDto.Id, x => x.Category);


            mapper.Map(skillUpdateDto, skill);
            //Skill.Title = SkillUpdateDto.Title;
            //Skill.Content = SkillUpdateDto.Content;
            //Skill.CategoryId = SkillUpdateDto.CategoryId;
            skill.ModifiedDate = DateTime.Now;
            skill.ModifiedBy = userEmail;

            await unitOfWork.GetRepository<Skill>().UpdateAsync(skill);
            await unitOfWork.SaveAsync();

            return skill.Title;

        }
        public async Task<string> SafeDeleteSkillAsync(Guid skillId)
        {
            var userEmail = _user.GetLoggedInEmail();
            var skill = await unitOfWork.GetRepository<Skill>().GetByGuidAsync(skillId);

            skill.IsDeleted = true;
            skill.DeletedDate = DateTime.Now;
            skill.DeletedBy = userEmail;

            await unitOfWork.GetRepository<Skill>().UpdateAsync(skill);
            await unitOfWork.SaveAsync();

            return skill.Title;
        }

        public async Task<List<SkillDto>> GetAllSkillsWithCategoryDeletedAsync()
        {
            var skills = await unitOfWork.GetRepository<Skill>().GetAllAsync(x => x.IsDeleted, x => x.Category);
            var map = mapper.Map<List<SkillDto>>(skills);

            return map;
        }

        public async Task<string> UndoDeleteSkillAsync(Guid skillId)
        {
            var skill = await unitOfWork.GetRepository<Skill>().GetByGuidAsync(skillId);

            skill.IsDeleted = false;
            skill.DeletedDate = null;
            skill.DeletedBy = null;

            await unitOfWork.GetRepository<Skill>().UpdateAsync(skill);
            await unitOfWork.SaveAsync();

            return skill.Title;
        }

    }
}