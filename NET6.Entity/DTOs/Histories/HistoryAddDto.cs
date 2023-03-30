using NET6.Entity.DTOs.Categories;

namespace NET6.Entity.DTOs.Histories
{
    public class HistoryAddDto
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string SFDate { get; set; }
        public Guid CategoryId { get; set; }

        public IList<CategoryDto> Categories { get; set; }
    }
}
