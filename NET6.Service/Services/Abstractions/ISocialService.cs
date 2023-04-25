using NET6.Entity.DTOs.Socials;
using NET6.Entity.Entities;

namespace NET6.Service.Services.Abstractions
{
    public interface ISocialService
    {
        Task<List<SocialDto>> GetAllSocialsNonDeleted();
        Task<List<SocialDto>> GetAllSocialsDeleted();
        Task CreateSocialAsync(SocialAddDto socialAddDto);
        Task<Social> GetSocialByGuid(Guid id);
        Task<string> UpdateSocialAsync(SocialUpdateDto socialUpdateDto);
        Task<string> SafeDeleteSocialAsync(Guid socialId);
        Task<string> UndoDeleteSocialAsync(Guid socialId);
    }
}
