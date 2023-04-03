using AutoMapper;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using NET6.Data.UnitOfWorks;
using NET6.Entity.DTOs.Abouts;
using NET6.Entity.Entities;
using NET6.Entity.Enums;
using NET6.Service.Extensions;
using NET6.Service.Helpers.Images;
using NET6.Service.Services.Abstractions;



namespace NET6.Service.Services.Concrete
{
    public class AboutService : IAboutService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IImageHelper imageHelper;
        private readonly ClaimsPrincipal _user;

        public AboutService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
            this.imageHelper = imageHelper;
        }



        public async Task<List<AboutDto>> GetAllAboutsNonDeletedAsync()
        {

            var abouts = await unitOfWork.GetRepository<About>().GetAllAsync();
            var map = mapper.Map<List<AboutDto>>(abouts);

            return map;
        }
        public async Task<AboutDto> GetAboutsNonDeletedAsync(Guid aboutId)
        {

            var abouts = await unitOfWork.GetRepository<About>().GetAsync(x => !x.IsDeleted && x.Id == aboutId, i => i.Image, u => u.User);
            var map = mapper.Map<AboutDto>(abouts);

            return map;
        }
        public async Task<string> UpdateAboutAsync(AboutUpdateDto aboutUpdateDto)
        {
            var userEmail = _user.GetLoggedInEmail();

            var about = await unitOfWork.GetRepository<About>().GetAsync(x => !x.IsDeleted && x.Id == aboutUpdateDto.Id,i => i.Image);


            if (aboutUpdateDto.Photo != null)
            {

                imageHelper.Delete(about.Image.FileName);

                var imageUpload = await imageHelper.Upload(aboutUpdateDto.Title, aboutUpdateDto.Photo, ImageType.About);
                Image image = new(imageUpload.FullName, aboutUpdateDto.Photo.ContentType, userEmail);
                await unitOfWork.GetRepository<Image>().AddAsync(image);

                about.ImageId = image.Id;

                if (aboutUpdateDto.Image != about.Image)
                {
                    aboutUpdateDto.Image = image;
                }


            }


            mapper.Map(aboutUpdateDto, about);

            about.ModifiedDate = DateTime.Now;
            about.ModifiedBy = userEmail;


            await unitOfWork.GetRepository<About>().UpdateAsync(about);
            await unitOfWork.SaveAsync();

            return about.Title;
        }
        public async Task<string> UndoDeleteAboutAsync(Guid aboutId)
        {
            var about = await unitOfWork.GetRepository<About>().GetByGuidAsync(aboutId);

            about.IsDeleted = false;
            about.DeletedDate = null;
            about.DeletedBy = null;

            await unitOfWork.GetRepository<About>().UpdateAsync(about);
            await unitOfWork.SaveAsync();

            return about.Title;
        }
        public async Task<string> SafeDeleteAboutAsync(Guid aboutId)
        {
            var userEmail = _user.GetLoggedInEmail();
            var about = await unitOfWork.GetRepository<About>().GetByGuidAsync(aboutId);

            about.IsDeleted = true;
            about.DeletedDate = DateTime.Now;
            about.DeletedBy = userEmail;

            await unitOfWork.GetRepository<About>().UpdateAsync(about);
            await unitOfWork.SaveAsync();

            return about.Title;
        }




        public async Task<List<AboutDto>> GetAllAboutsDeletedAsync()
        {
            var abouts = await unitOfWork.GetRepository<About>().GetAllAsync(x => x.IsDeleted);
            var map = mapper.Map<List<AboutDto>>(abouts);

            return map;
        }

        public async Task CreateAboutAsync(AboutAddDto aboutAddDto)
        {
            var userId = _user.GetLoggedInUserId();
            var userEmail = _user.GetLoggedInEmail();

            var imageUpload = await imageHelper.Upload(aboutAddDto.Title, aboutAddDto.Photo, ImageType.About);
            Image image = new(imageUpload.FullName, aboutAddDto.Photo.ContentType, userEmail);
            await unitOfWork.GetRepository<Image>().AddAsync(image);

            var about = new About(aboutAddDto.Title, aboutAddDto.Content,aboutAddDto.Job ,userId, userEmail, image.Id);

            await unitOfWork.GetRepository<About>().AddAsync(about);
            await unitOfWork.SaveAsync();
        }

        public async Task<AboutListDto> GetAllByPagingAsync()
        {
            var abouts = await unitOfWork.GetRepository<About>().GetAllAsync(a => !a.IsDeleted, i => i.Image, u => u.User);

            return new AboutListDto
            {
                Abouts = abouts
            };
        }
    }
}