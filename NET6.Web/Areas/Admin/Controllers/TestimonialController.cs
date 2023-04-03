using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using NET6.Entity.DTOs.Testimonials;
using NET6.Entity.Entities;
using NET6.Service.Extensions;
using NET6.Service.Services.Abstractions;
using NET6.Web.Consts;
using NET6.Web.ResultMessages;


namespace NET6.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService testimonialService;
        private readonly IMapper mapper;
        private readonly IValidator<Testimonial> validator;
        private readonly IToastNotification toast;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper, IValidator<Testimonial> validator, IToastNotification toast)
        {
            this.testimonialService = testimonialService;
            this.mapper = mapper;
            this.validator = validator;
            this.toast = toast;
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}, {RoleConsts.User}")]
        public async Task<IActionResult> Index()
        {
            var testimonials = await testimonialService.GetAllTestimonialsNonDeletedAsync();
            return View(testimonials);
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> DeletedTestimonial()
        {
            var testimonials = await testimonialService.GetAllTestimonialsDeletedAsync();
            return View(testimonials);
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Add()
        {
            var testimonials = await testimonialService.GetAllTestimonialsNonDeletedAsync();
            return View();
        }
        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Add(TestimonialAddDto testimonialAddDto)
        {

            var map = mapper.Map<Testimonial>(testimonialAddDto);
            var result = await validator.ValidateAsync(map);


            if (result.IsValid)
            {
                await testimonialService.CreateTestimonialAsync(testimonialAddDto);
                toast.AddSuccessToastMessage(Messages.Testimonial.Add(testimonialAddDto.Title), new ToastrOptions { Title = "İşlem Başarılı" });

                return RedirectToAction("Index", "Testimonial", new { Area = "Admin" });

            }
            else
            {
                result.AddToModelState(this.ModelState);
            }


            return View();
        }



        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(Guid testimonialId)
        {
            var testimonial = await testimonialService.GetTestimonialNonDeletedAsync(testimonialId);

            var testimonialUpdateDto = mapper.Map<TestimonialUpdateDto>(testimonial);

            return View(testimonialUpdateDto);
        }
        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(TestimonialUpdateDto testimonialUpdateDto)
        {

            var map = mapper.Map<Testimonial>(testimonialUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var title = await testimonialService.UpdateTestimonialAsync(testimonialUpdateDto);
                toast.AddSuccessToastMessage(Messages.Testimonial.Update(title), new ToastrOptions() { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Testimonial", new { Area = "Admin" });

            }
            else
            {
                result.AddToModelState(this.ModelState);
            }


            return View(testimonialUpdateDto);
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Delete(Guid testimonialId)
        {
            var title = await testimonialService.SafeDeleteTestimonialAsync(testimonialId);
            toast.AddSuccessToastMessage(Messages.Testimonial.Delete(title), new ToastrOptions() { Title = "İşlem Başarılı" });


            return RedirectToAction("Index", "Testimonial", new { Area = "Admin" });
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> UndoDelete(Guid testimonialId)
        {
            var title = await testimonialService.UndoDeleteTestimonialAsync(testimonialId);
            toast.AddSuccessToastMessage(Messages.Testimonial.UndoDelete(title), new ToastrOptions() { Title = "İşlem Başarılı" });


            return RedirectToAction("Index", "Testimonial", new { Area = "Admin" });
        }




    }
}
