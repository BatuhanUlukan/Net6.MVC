using NET6.Entity.DTOs.Categories;
using NET6.Entity.Entities;

namespace NET6.Entity.DTOs.Histories
{
    public class HistoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public CategoryDto Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public string SFDate { get; set; }
        public AppUser User { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
