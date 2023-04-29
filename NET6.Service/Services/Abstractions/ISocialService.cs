
using NET6.Entity.DTOs.Socials;

namespace NET6.Service.Services.Abstractions
{
    public interface ISocialService
    {
        Task<List<SocialDto>> GetAllSocialsNonDeletedAsync();
        Task<List<SocialDto>> GetAllSocialsDeletedAsync();
        Task<SocialDto> GetSocialNonDeletedAsync(Guid socialId);
        Task CreateSocialAsync(SocialAddDto socialAddDto);
        Task<string> UpdateSocialAsync(SocialUpdateDto socialUpdateDto);
        Task<string> SafeDeleteSocialAsync(Guid socialId);
        Task<string> UndoDeleteSocialAsync(Guid socialId);


    }
}
