using NET6.Entity.DTOs.Categories;

namespace NET6.Entity.DTOs.Histories
{
    public class HistoryUpdateDto
    {
        public Guid Id { get; set; }
        public string SFDate { get; set; }
        public string Name { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }

        public IList<CategoryDto> Categories { get; set; }
    }
}
