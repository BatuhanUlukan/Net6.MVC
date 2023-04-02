using NET6.Entity.Entities;

namespace NET6.Entity.DTOs.Abouts
{
    public class AboutListDto
    {
        public List<About> Abouts { get; set; }

        public List<Image> Image { get; set; }
        public virtual bool IsAscending { get; set; } = false;


    }
}
