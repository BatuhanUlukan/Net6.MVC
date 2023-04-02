using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using NET6.Entity.Entities;
using NET6.Service.Extensions;
using NET6.Service.Services.Abstractions;
using NET6.Web.Consts;
using NET6.Web.ResultMessages;
using NET6.Entity.DTOs.Abouts;

namespace NET6.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly IAboutService aboutService;
        private readonly IMapper mapper;
        private readonly IValidator<About> validator;
        private readonly IToastNotification toast;

        public AboutController(IAboutService aboutService, IMapper mapper, IValidator<About> validator, IToastNotification toast)
        {
            this.aboutService = aboutService;
            this.mapper = mapper;
            this.validator = validator;
            this.toast = toast;
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}, {RoleConsts.User}")]
        public async Task<IActionResult> Index()
        {
            var abouts = await aboutService.GetAllAboutsNonDeletedAsync();
            return View(abouts);
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> DeletedAbout()
        {
            var abouts = await aboutService.GetAllAboutsDeletedAsync();
            return View(abouts);
        }


        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(Guid aboutId)
        {
            var about = await aboutService.GetAboutsNonDeletedAsync(aboutId);


            var aboutUpdateDto = mapper.Map<AboutUpdateDto>(about);


            return View(aboutUpdateDto);
        }
        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(AboutUpdateDto aboutUpdateDto)
        {

            var map = mapper.Map<About>(aboutUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var title = await aboutService.UpdateAboutAsync(aboutUpdateDto);
                toast.AddSuccessToastMessage(Messages.About.Update(title), new ToastrOptions() { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "About", new { Area = "Admin" });

            }
            else
            {
                result.AddToModelState(this.ModelState);
            }

            return View(aboutUpdateDto);
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Delete(Guid aboutId)
        {
            var title = await aboutService.SafeDeleteAboutAsync(aboutId);
            toast.AddSuccessToastMessage(Messages.About.Delete(title), new ToastrOptions() { Title = "İşlem Başarılı" });


            return RedirectToAction("Index", "About", new { Area = "Admin" });
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> UndoDelete(Guid aboutId)
        {
            var title = await aboutService.UndoDeleteAboutAsync(aboutId);
            toast.AddSuccessToastMessage(Messages.About.UndoDelete(title), new ToastrOptions() { Title = "İşlem Başarılı" });


            return RedirectToAction("Index", "About", new { Area = "Admin" });
        }




    }
}
