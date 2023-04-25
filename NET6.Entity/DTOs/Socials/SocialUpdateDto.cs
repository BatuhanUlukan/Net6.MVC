using NET6.Entity.DTOs.Links;

namespace NET6.Entity.DTOs.Socials
{
    public class SocialUpdateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public Guid LinkId { get; set; }
        public IList<LinkDto> Links { get; set; }
    }
}
