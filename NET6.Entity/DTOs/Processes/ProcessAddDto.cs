using Microsoft.AspNetCore.Http;

namespace NET6.Entity.DTOs.Processes
{
    public class ProcessAddDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public IFormFile Photo { get; set; }

    }
}
