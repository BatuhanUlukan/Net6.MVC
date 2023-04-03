using Microsoft.AspNetCore.Http;
using NET6.Entity.DTOs.Categories;
using NET6.Entity.Entities;

namespace NET6.Entity.DTOs.Skills
{
    public class SkillUpdateDto
    {
        public Guid Id { get; set; }
        public string Percent{ get; set; }
        public string Title { get; set; }
        public Guid CategoryId { get; set; }

        public IList<CategoryDto> Categories { get; set; }
    }
}
