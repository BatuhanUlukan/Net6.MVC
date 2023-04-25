using NET6.Entity.Entities;

namespace NET6.Entity.DTOs.Abouts
{
    public class AboutListDto
    {
        public IList<About> Abouts { get; set; }
        public Seo Seos { get; set; }
        public Link Links { get; set; }
        public Image Image { get; set; }
        public virtual bool IsAscending { get; set; } = false;
    }
}
