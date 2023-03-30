using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using NET6.Entity.DTOs.Mains;
using NET6.Entity.Entities;
using NET6.Service.Extensions;
using NET6.Service.Services.Abstractions;
using NET6.Web.Consts;
using NET6.Web.ResultMessages;


namespace NET6.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MainController : Controller
    {

        private readonly IMainService mainService;
        private readonly IMapper mapper;
        private readonly IValidator<Main> validator;
        private readonly IToastNotification toast;

        public MainController(IMainService mainService, IMapper mapper, IValidator<Main> validator, IToastNotification toast)
        {
            this.mainService = mainService;
            this.mapper = mapper;
            this.validator = validator;
            this.toast = toast;
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Index()
        {
            var mains = await mainService.GetAllMainsAsync();
            return View(mains);
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(Guid mainId)
        {
            var mains = await mainService.GetMainAsync(mainId);

            var mainUpdateDto = mapper.Map<MainUpdateDto>(mains);

            return View(mainUpdateDto);
        }
        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(MainUpdateDto mainUpdateDto)
        {

            var map = mapper.Map<Main>(mainUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var title = await mainService.UpdateMainAsync(mainUpdateDto);
                toast.AddSuccessToastMessage(Messages.Main.Update(title), new ToastrOptions() { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Main", new { Area = "Admin" });

            }
            else
            {
                result.AddToModelState(this.ModelState);
            }

            return View(mainUpdateDto);
        }
    }
}
