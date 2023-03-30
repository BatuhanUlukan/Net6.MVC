using NET6.Entity.DTOs.Mains;

namespace NET6.Service.Services.Abstractions
{
    public interface IMainService
    {
        Task<MainDto> GetMainAsync(Guid mainId);
        Task<List<MainDto>> GetAllMainsAsync();
        Task<string> UpdateMainAsync(MainUpdateDto mainUpdateDto);

    }
}
