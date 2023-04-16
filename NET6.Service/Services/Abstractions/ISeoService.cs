using NET6.Entity.DTOs.Seos;
using NET6.Entity.Entities;


namespace NET6.Service.Services.Abstractions
{
    public interface ISeoService
    {
        Task<List<SeoDto>> GetAllSeosNonDeleted();
        Task<List<SeoDto>> GetAllSeosDeleted();
        Task CreateSeoAsync(SeoAddDto seoAddDto);
        Task<Seo> GetSeoByGuid(Guid id);
        Task<string> UpdateSeoAsync(SeoUpdateDto seoUpdateDto);
        Task<string> SafeDeleteSeoAsync(Guid seoId);
        Task<string> UndoDeleteSeoAsync(Guid seoId);
    }
}
