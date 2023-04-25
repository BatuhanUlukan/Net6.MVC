using AutoMapper;
using Microsoft.AspNetCore.Http;
using NET6.Data.UnitOfWorks;
using NET6.Entity.DTOs.Processes;
using NET6.Entity.DTOs.Testimonials;
using NET6.Entity.Entities;
using NET6.Entity.Enums;
using NET6.Service.Extensions;
using NET6.Service.Helpers.Images;
using NET6.Service.Services.Abstractions;
using System.Diagnostics;
using System.Security.Claims;


namespace NET6.Service.Services.Concrete
{
    public class TestimonialService : ITestimonialService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IImageHelper imageHelper;
        private readonly ClaimsPrincipal _user;

        public TestimonialService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
            this.imageHelper = imageHelper;
        }

        public async Task CreateTestimonialAsync(TestimonialAddDto testimonialAddDto)
        {
            var userId = _user.GetLoggedInUserId();
            var userEmail = _user.GetLoggedInEmail();

            var imageUpload = await imageHelper.Upload(testimonialAddDto.Title, testimonialAddDto.Photo, ImageType.Tstmnal);
            Image image = new(imageUpload.FullName, testimonialAddDto.Photo.ContentType, userEmail);
            await unitOfWork.GetRepository<Image>().AddAsync(image);

            var testimonial = new Testimonial(testimonialAddDto.Title, userId, userEmail, image.Id,testimonialAddDto.LinkId);

            await unitOfWork.GetRepository<Testimonial>().AddAsync(testimonial);
            await unitOfWork.SaveAsync();
        }

        public async Task<List<TestimonialDto>> GetAllTestimonialsNonDeletedAsync()
        {

            var testimonials = await unitOfWork.GetRepository<Testimonial>().GetAllAsync(x => !x.IsDeleted,l=>l.Link);
            var map = mapper.Map<List<TestimonialDto>>(testimonials);

            return map;
        }
        public async Task<TestimonialDto> GetTestimonialNonDeletedAsync(Guid testimonialId)
        {

            var testimonial = await unitOfWork.GetRepository<Testimonial>().GetAsync(x => !x.IsDeleted && x.Id == testimonialId, i => i.Image, u => u.User, l => l.Link);
            var map = mapper.Map<TestimonialDto>(testimonial);

            return map;
        }

        public async Task<string> SafeDeleteTestimonialAsync(Guid testimonialId)
        {
            var userEmail = _user.GetLoggedInEmail();
            var testimonial = await unitOfWork.GetRepository<Testimonial>().GetByGuidAsync(testimonialId);

            testimonial.IsDeleted = true;
            testimonial.DeletedDate = DateTime.Now;
            testimonial.DeletedBy = userEmail;

            await unitOfWork.GetRepository<Testimonial>().UpdateAsync(testimonial);
            await unitOfWork.SaveAsync();

            return testimonial.Title;
        }

        public async Task<List<TestimonialDto>> GetAllTestimonialsDeletedAsync()
        {
            var testimonials = await unitOfWork.GetRepository<Testimonial>().GetAllAsync(x => x.IsDeleted, l => l.Link);
            var map = mapper.Map<List<TestimonialDto>>(testimonials);

            return map;
        }

        public async Task<string> UndoDeleteTestimonialAsync(Guid testimonialId)
        {
            var testimonial = await unitOfWork.GetRepository<Testimonial>().GetByGuidAsync(testimonialId);

            testimonial.IsDeleted = false;
            testimonial.DeletedDate = null;
            testimonial.DeletedBy = null;

            await unitOfWork.GetRepository<Testimonial>().UpdateAsync(testimonial);
            await unitOfWork.SaveAsync();

            return testimonial.Title;
        }

        public async Task<string> UpdateTestimonialAsync(TestimonialUpdateDto testimonialUpdateDto)
        {
            var userEmail = _user.GetLoggedInEmail();

            var testimonial = await unitOfWork.GetRepository<Testimonial>().GetAsync(x => !x.IsDeleted && x.Id == testimonialUpdateDto.Id, i => i.Image, l => l.Link);


            if (testimonialUpdateDto.Photo != null)
            {


                imageHelper.Delete(testimonial.Image.FileName);



                var imageUpload = await imageHelper.Upload(testimonialUpdateDto.Title, testimonialUpdateDto.Photo, ImageType.Tstmnal);
                Image image = new(imageUpload.FullName, testimonialUpdateDto.Photo.ContentType, userEmail);
                await unitOfWork.GetRepository<Image>().AddAsync(image);

                testimonial.ImageId = image.Id;

                if (testimonialUpdateDto.Image != testimonial.Image)
                {
                    testimonialUpdateDto.Image = image;
                }
                else
                {
                    testimonialUpdateDto.Image = testimonial.Image; // Keep the existing image if no image is selected
                }
            }


            mapper.Map(testimonialUpdateDto, testimonial);

            testimonial.ModifiedDate = DateTime.Now;
            testimonial.ModifiedBy = userEmail;


            await unitOfWork.GetRepository<Testimonial>().UpdateAsync(testimonial);
            await unitOfWork.SaveAsync();

            return testimonial.Title;
        }
        public async Task<TestimonialListDto> GetAllByPagingAsync()
        {
            var testimonials = await unitOfWork.GetRepository<Testimonial>().GetAllAsync(a => !a.IsDeleted, i => i.Image, u => u.User, l => l.Link);

            return new TestimonialListDto
            {
                Testimonials = testimonials
            };
        }
    }
}