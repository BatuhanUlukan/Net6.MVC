using NET6.Entity.Entities;


namespace NET6.Entity.DTOs.Histories
{
    public class HistoryListDto
    {
        public IList<History> Histories { get; set; }
        public Guid? CategoryId { get; set; }
        public virtual bool IsAscending { get; set; } = false;


    }
}
