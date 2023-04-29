using NET6.Entity.DTOs.Links;

namespace NET6.Entity.DTOs.Socials
{
    public class SocialDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public LinkDto Link { get; set; }

    }

}
