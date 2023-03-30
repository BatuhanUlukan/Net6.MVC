using Microsoft.AspNetCore.Http;
using NET6.Entity.DTOs.Images;
using NET6.Entity.Enums;

namespace NET6.Service.Helpers.Images
{
    public interface IImageHelper
    {
        Task<ImageUploadedDto> Upload(string name, IFormFile imageFile, ImageType imageType, string folderName = null);
        void Delete(string imageName);

    }
}
