using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using NET6.Entity.DTOs.Links;
using NET6.Entity.Entities;
using NET6.Service.Extensions;
using NET6.Service.Services.Abstractions;
using NET6.Web.ResultMessages;
using NToastNotify;

namespace NET6.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LinkController : Controller
    {
        private readonly ILinkService linkService;
        private readonly IValidator<Link> validator;
        private readonly IMapper mapper;
        private readonly IToastNotification toast;

        public LinkController(ILinkService linkService, IValidator<Link> validator, IMapper mapper, IToastNotification toast)
        {
            this.linkService = linkService;
            this.validator = validator;
            this.mapper = mapper;
            this.toast = toast;
        }
        public async Task<IActionResult> Index()
        {
            var links = await linkService.GetAllLinksNonDeleted();
            return View(links);
        }
        public async Task<IActionResult> DeletedLink()
        {
            var links = await linkService.GetAllLinksDeleted();
            return View(links);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(LinkAddDto linkAddDto)
        {
            var map = mapper.Map<Link>(linkAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await linkService.CreateLinkAsync(linkAddDto);
                toast.AddSuccessToastMessage(Messages.Link.Add(linkAddDto.Name), new ToastrOptions { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Link", new { Area = "Admin" });
            }

            result.AddToModelState(this.ModelState);
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> AddWithAjax([FromBody] LinkAddDto linkAddDto)
        {
            var map = mapper.Map<Link>(linkAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await linkService.CreateLinkAsync(linkAddDto);
                toast.AddSuccessToastMessage(Messages.Link.Add(linkAddDto.Name), new ToastrOptions { Title = "İşlem Başarılı" });

                return Json(Messages.Link.Add(linkAddDto.Name));
            }
            else
            {
                toast.AddErrorToastMessage(result.Errors.First().ErrorMessage, new ToastrOptions { Title = "İşlem Başarısız" });
                return Json(result.Errors.First().ErrorMessage);
            }
        }


        [HttpGet]
        public async Task<IActionResult> Update(Guid linkId)
        {
            var link = await linkService.GetLinkByGuid(linkId);
            var map = mapper.Map<Link, LinkUpdateDto>(link);

            return View(map);
        }
        [HttpPost]
        public async Task<IActionResult> Update(LinkUpdateDto linkUpdateDto)
        {
            var map = mapper.Map<Link>(linkUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var name = await linkService.UpdateLinkAsync(linkUpdateDto);
                toast.AddSuccessToastMessage(Messages.Link.Update(name), new ToastrOptions { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Link", new { Area = "Admin" });
            }

            result.AddToModelState(this.ModelState);
            return View();
        }
        public async Task<IActionResult> Delete(Guid linkId)
        {
            var name = await linkService.SafeDeleteLinkAsync(linkId);
            toast.AddSuccessToastMessage(Messages.Link.Delete(name), new ToastrOptions() { Title = "İşlem Başarılı" });

            return RedirectToAction("Index", "Link", new { Area = "Admin" });
        }
        public async Task<IActionResult> UndoDelete(Guid linkId)
        {
            var name = await linkService.UndoDeleteLinkAsync(linkId);
            toast.AddSuccessToastMessage(Messages.Link.Delete(name), new ToastrOptions() { Title = "İşlem Başarılı" });

            return RedirectToAction("Index", "Link", new { Area = "Admin" });
        }
    }
}