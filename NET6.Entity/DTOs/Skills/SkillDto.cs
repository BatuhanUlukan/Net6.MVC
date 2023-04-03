using NET6.Entity.DTOs.Categories;
using NET6.Entity.Entities;

namespace NET6.Entity.DTOs.Skills
{
    public class SkillDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Percent { get; set; }
        public CategoryDto Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public AppUser User { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
