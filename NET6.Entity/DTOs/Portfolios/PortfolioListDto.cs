using NET6.Entity.Entities;

namespace NET6.Entity.DTOs.Portfolios
{
    public class PortfolioListDto
    {
        public IList<Portfolio> Portfolios { get; set; }
        public Guid? CategoryId { get; set; }
        public Link Links { get; set; }

        public virtual int CurrentPage { get; set; } = 1;
        public virtual int PageSize { get; set; } = 3;
        public virtual int TotalCount { get; set; }
        public virtual int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize));
        public virtual bool ShowPrevious => CurrentPage > 1;
        public virtual bool ShowNext => CurrentPage < TotalPages;
        public virtual bool IsAscending { get; set; } = false;
    }
}
