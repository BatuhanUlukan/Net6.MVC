using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using NET6.Entity.DTOs.Images;
using NET6.Entity.Enums;
using System.Text.RegularExpressions;


namespace NET6.Service.Helpers.Images
{
    public class ImageHelper : IImageHelper
    {
        private readonly string wwwroot;
        private readonly IWebHostEnvironment env;
        private const string imgFolder = "images";
        private const string articleImagesFolder = "article-images";
        private const string portfolioImagesFolder = "portfolio-images";
        private const string pageImagesFolder = "page-images";
        private const string userImagesFolder = "user-images";
        private const string testimonialImagesFolder = "testimonial-images";
        private const string aboutImagesFolder = "about-images";
        private const string serviceImagesFolder = "service-images";


        public ImageHelper(IWebHostEnvironment env)
        {
            this.env = env;
            wwwroot = env.WebRootPath;
        }

        private string ReplaceInvalidChars(string fileName)
        {
            string pattern = @"[^a-zA-Z0-9_-]";
            string replacement = "";
            Regex regex = new Regex(pattern);
            return regex.Replace(fileName, replacement);
        }

        public async Task<ImageUploadedDto> Upload(string name, IFormFile imageFile, ImageType imageType, string folderName = null)
        {
            folderName = string.IsNullOrWhiteSpace(folderName)
            ? imageType switch
            {
                ImageType.User => userImagesFolder,
                ImageType.Post => articleImagesFolder,
                ImageType.Work => portfolioImagesFolder,
                ImageType.MPage => pageImagesFolder,
                ImageType.Tstmnal => testimonialImagesFolder,
                ImageType.About => aboutImagesFolder,
                ImageType.Service => serviceImagesFolder,
                _ => imgFolder,
            }
            : ReplaceInvalidChars(folderName);



            if (!Directory.Exists($"{wwwroot}/{imgFolder}/{folderName}"))
                Directory.CreateDirectory($"{wwwroot}/{imgFolder}/{folderName}");

            string oldFileName = Path.GetFileNameWithoutExtension(imageFile.FileName);
            string fileExtension = Path.GetExtension(imageFile.FileName);

            name = ReplaceInvalidChars(name);

            DateTime dateTime = DateTime.Now;

            string newFileName = $"{name}_{dateTime.Millisecond}{fileExtension}";

            var path = Path.Combine(wwwroot, imgFolder, folderName, newFileName);


            if (imageFile != null)
            {
                await using var stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);
                await imageFile.CopyToAsync(stream);
                await stream.FlushAsync();
            }

            string message = imageType == ImageType.User
                 ? $"{newFileName} isimli kullanıcı resmi başarı ile eklenmiştir."
                 : imageType == ImageType.Post
                 ? $"{newFileName} isimli makale resmi başarı ile eklenmiştir."
                 : imageType == ImageType.Work
                 ? $"{newFileName} isimli portföy resmi başarı ile eklenmiştir."
                 : imageType == ImageType.MPage
                 ? $"{newFileName} isimli anasayfa resmi başarı ile eklenmiştir."
                 : imageType == ImageType.Tstmnal
                 ? $"{newFileName} isimli tavsiye resmi başarı ile eklenmiştir."
                 : imageType == ImageType.About
                 ? $"{newFileName} isimli anasayfa resmi başarı ile eklenmiştir."
                 : imageType == ImageType.Service
                 ? $"{newFileName} isimli servis resmi başarı ile eklenmiştir."
                 : "Resim eklendi.";


            return new ImageUploadedDto()
            {
                FullName = $"{folderName}/{newFileName}"
            };
        }


        public void Delete(string imageName)
        {
            var fileToDelete = Path.Combine(wwwroot, imgFolder, imageName);
            if (File.Exists(fileToDelete))
                File.Delete(fileToDelete);


        }
    }
}
