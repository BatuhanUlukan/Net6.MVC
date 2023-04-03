using NET6.Entity.DTOs.Processes;


namespace NET6.Service.Services.Abstractions
{
    public interface IProcessService
    {
        Task<List<ProcessDto>> GetAllProcessesNonDeletedAsync();
        Task<List<ProcessDto>> GetAllProcessesDeletedAsync();
        Task<ProcessDto> GetProcessesNonDeletedAsync(Guid processId);
        Task CreateProcessAsync(ProcessAddDto processAddDto);
        Task<string> UpdateProcessAsync(ProcessUpdateDto processUpdateDto);
        Task<string> SafeDeleteProcessAsync(Guid processId);
        Task<string> UndoDeleteProcessAsync(Guid processId);
        Task<ProcessListDto> GetAllByPagingAsync();
    }
}
