using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET6.Entity.DTOs.Socials;
using NET6.Entity.Entities;
using NET6.Service.Extensions;
using NET6.Service.Services.Abstractions;
using NET6.Web.Consts;
using NET6.Web.ResultMessages;
using NToastNotify;


namespace NET6.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialController : Controller
    {
        private readonly ISocialService socialService;
        private readonly IMapper mapper;
        private readonly IValidator<Social> validator;
        private readonly IToastNotification toast;
        private readonly ILinkService linkService;


        public SocialController(ISocialService socialService, ILinkService linkService, IMapper mapper, IValidator<Social> validator, IToastNotification toast)
        {
            this.socialService = socialService;
            this.mapper = mapper;
            this.linkService = linkService;
            this.validator = validator;
            this.toast = toast;
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}, {RoleConsts.User}")]
        public async Task<IActionResult> Index()
        {
            var socials = await socialService.GetAllSocialsNonDeleted();
            return View(socials);
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> DeletedSocial()
        {
            var socials = await socialService.GetAllSocialsDeleted();
            return View(socials);
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Add()
        {
            var socials = await socialService.GetAllSocialsNonDeleted();
            var links = await linkService.GetAllLinksNonDeleted();

            var socialAddDto = new SocialAddDto
            {
                Links = links
            };
            return View(socialAddDto);
        }
        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Add(SocialAddDto socialAddDto)
        {

            var map = mapper.Map<Social>(socialAddDto);
            var result = await validator.ValidateAsync(map);


            if (result.IsValid)
            {
                await socialService.CreateSocialAsync(socialAddDto);
                toast.AddSuccessToastMessage(Messages.Social.Add(socialAddDto.Name), new ToastrOptions { Title = "İşlem Başarılı" });

                return RedirectToAction("Index", "Social", new { Area = "Admin" });

            }
            else
            {
                result.AddToModelState(this.ModelState);
            }

            var links = await linkService.GetAllLinksNonDeleted();

            return View(new SocialAddDto { Links = links });
        }



        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(Guid socialId)
        {
            var social = await socialService.GetSocialByGuid(socialId);
            var links = await linkService.GetAllLinksNonDeleted();


            var socialUpdateDto = mapper.Map<SocialUpdateDto>(social);

            socialUpdateDto.Links = links;

            return View(socialUpdateDto);
        }

        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(SocialUpdateDto socialUpdateDto)
        {

            var map = mapper.Map<Social>(socialUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var title = await socialService.UpdateSocialAsync(socialUpdateDto);
                toast.AddSuccessToastMessage(Messages.Social.Update(title), new ToastrOptions() { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Social", new { Area = "Admin" });

            }
            else
            {
                result.AddToModelState(this.ModelState);
            }
            var links = await linkService.GetAllLinksNonDeleted();

            socialUpdateDto.Links = links;


            return View(socialUpdateDto);
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Delete(Guid socialId)
        {
            var title = await socialService.SafeDeleteSocialAsync(socialId);
            toast.AddSuccessToastMessage(Messages.Social.Delete(title), new ToastrOptions() { Title = "İşlem Başarılı" });


            return RedirectToAction("Index", "Social", new { Area = "Admin" });
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> UndoDelete(Guid socialId)
        {
            var title = await socialService.UndoDeleteSocialAsync(socialId);
            toast.AddSuccessToastMessage(Messages.Social.UndoDelete(title), new ToastrOptions() { Title = "İşlem Başarılı" });


            return RedirectToAction("Index", "Social", new { Area = "Admin" });
        }




    }
}
