namespace NET6.Entity.DTOs.Seos
{
    public class SeoUpdateDto
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
    }
}
