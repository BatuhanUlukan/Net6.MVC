using NET6.Entity.Entities;


namespace NET6.Entity.DTOs.Skills
{
    public class SkillListDto
    {
        public IList<Skill> Skills { get; set; }
        public Guid? CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual bool IsAscending { get; set; } = false;


    }
}
