using NET6.Entity.DTOs.Histories;

namespace NET6.Service.Services.Abstractions
{
    public interface IHistoryService
    {
        Task<List<HistoryDto>> GetAllHistoriesWithCategoryNonDeletedAsync();
        Task<List<HistoryDto>> GetAllHistoriesWithCategoryDeletedAsync();
        Task<HistoryDto> GetHistoryWithCategoryNonDeletedAsync(Guid historyId);
        Task CreateHistoryAsync(HistoryAddDto historyAddDto);
        Task<string> UpdateHistoryAsync(HistoryUpdateDto historyUpdateDto);
        Task<string> SafeDeleteHistoryAsync(Guid historyId);
        Task<string> UndoDeleteHistoryAsync(Guid historyId);

    }
}
