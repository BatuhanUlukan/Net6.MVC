using NET6.Entity.DTOs.Abouts;
using NET6.Entity.DTOs.Histories;
using NET6.Entity.DTOs.Skills;

namespace NET6.Service.Services.Abstractions
{
    public interface ISkillService
    {
        Task<List<SkillDto>> GetAllSkillsWithCategoryNonDeletedAsync();
        Task<List<SkillDto>> GetAllSkillsWithCategoryDeletedAsync();
        Task<SkillDto> GetSkillWithCategoryNonDeletedAsync(Guid skillId);
        Task CreateSkillAsync(SkillAddDto skillAddDto);
        Task<string> UpdateSkillAsync(SkillUpdateDto skillUpdateDto);
        Task<string> SafeDeleteSkillAsync(Guid skillId);
        Task<string> UndoDeleteSkillAsync(Guid skillId);

    }
}
