using AutoMapper;
using NET6.Data.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using NET6.Entity.DTOs.Mains;
using NET6.Entity.Entities;
using NET6.Entity.Enums;
using NET6.Service.Extensions;
using NET6.Service.Helpers.Images;
using NET6.Service.Services.Abstractions;

namespace NET6.Service.Services.Concrete
{
    public class MainService : IMainService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IImageHelper imageHelper;
        private readonly ClaimsPrincipal _user;

        public async Task<List<MainDto>> GetAllMainsAsync()
        {
            var mains = await unitOfWork.GetRepository<Main>().GetAllAsync(x => !x.IsDeleted);
            var map = mapper.Map<List<MainDto>>(mains);

            return map;
        }

        public async Task<MainDto> GetMainAsync(Guid mainId)
        {
            var main = await unitOfWork.GetRepository<Main>().GetAsync(x => x.Id == mainId, i => i.Image, u => u.User);
            var map = mapper.Map<MainDto>(main);

            return map;
        }


        public async Task<string> UpdateMainAsync(MainUpdateDto mainUpdateDto)
        {
            var userEmail = _user.GetLoggedInEmail();
            /*
            Retrieve the article to be updated:
            The method retrieves the article to be updated using the unit of work pattern and the repository pattern.
            It checks that the article is not deleted and that its ID matches the ID in the DTO.
            */
            var main = await unitOfWork.GetRepository<Main>().GetAsync(x => !x.IsDeleted && x.Id == mainUpdateDto.Id, i => i.Image);

            //Update the image:
            //If the DTO contains a new image (i.e. if the Photo property is not null),
            //the code first deletes the existing image (if any) and then uploads the new image using an imageHelper object.
            //The new Image object is then added to the unit of work and its ID is assigned to the article's ImageId property.
            if (mainUpdateDto.Photo != null)
            {

                imageHelper.Delete(main.Image.FileName);

                var imageUpload = await imageHelper.Upload(mainUpdateDto.Title, mainUpdateDto.Photo, ImageType.MPage);
                Image image = new(imageUpload.FullName, mainUpdateDto.Photo.ContentType, userEmail);
                await unitOfWork.GetRepository<Image>().AddAsync(image);

                main.ImageId = image.Id;

                if (mainUpdateDto.Image != main.Image)
                {
                    mainUpdateDto.Image = image;
                }


            }

            //Map the DTO to the entity:
            //The code uses AutoMapper to map the properties in the DTO to the properties in the article entity.
            //
            mapper.Map(mainUpdateDto, main);

            //Update the remaining properties:
            //The code updates the remaining properties of the article entity,including modified date, and modified by.
            main.ModifiedDate = DateTime.Now;
            main.ModifiedBy = userEmail;

            //Save the changes:
            //Finally, the code updates the article in the unit of work and saves the changes to the database using the SaveAsync method.
            await unitOfWork.GetRepository<Main>().UpdateAsync(main);
            await unitOfWork.SaveAsync();

            return main.Title;
        }
    }
}
