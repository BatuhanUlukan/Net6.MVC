using NET6.Entity.DTOs.Portfolios;

namespace NET6.Service.Services.Abstractions
{
    public interface IPortfolioService
    {
        Task<List<PortfolioDto>> GetAllPortfoliosWithCategoryNonDeletedAsync();
        Task<List<PortfolioDto>> GetAllPortfoliosWithCategoryDeletedAsync();
        Task<PortfolioDto> GetPortfolioWithCategoryNonDeletedAsync(Guid portfolioId);
        Task CreatePortfolioAsync(PortfolioAddDto portfolioAddDto);
        Task<string> UpdatePortfolioAsync(PortfolioUpdateDto portfolioUpdateDto);
        Task<string> SafeDeletePortfolioAsync(Guid portfolioId);
        Task<string> UndoDeletePortfolioAsync(Guid portfolioId);
        Task<PortfolioListDto> GetAllByPagingAsync(Guid? categoryId, int currentPage = 1, int pageSize = 3,
            bool isAscending = false);

        Task<PortfolioListDto> SearchAsync(string keyword, int currentPage = 1, int pageSize = 3,
            bool isAscending = false);
    }
}
