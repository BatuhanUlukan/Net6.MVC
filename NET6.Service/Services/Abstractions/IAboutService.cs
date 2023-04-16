using NET6.Entity.DTOs.Abouts
    ;

namespace NET6.Service.Services.Abstractions
{
    public interface IAboutService
    {
        Task<List<AboutDto>> GetAllAboutsNonDeletedAsync();
        Task<List<AboutDto>> GetAllAboutsDeletedAsync();
        Task<AboutDto> GetAboutsNonDeletedAsync(Guid aboutId);
        Task CreateAboutAsync(AboutAddDto aboutAddDto);
        Task<string> UpdateAboutAsync(AboutUpdateDto aboutUpdateDto);
        Task<string> SafeDeleteAboutAsync(Guid aboutId);
        Task<string> UndoDeleteAboutAsync(Guid aboutId);
        Task<AboutListDto> GetAllByPagingAsync();
        Task<AboutDto> GetAboutsAsync();



    }
}
