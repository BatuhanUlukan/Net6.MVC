using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using NET6.Entity.DTOs.Seos;
using NET6.Entity.Entities;
using NET6.Service.Extensions;
using NET6.Service.Services.Abstractions;
using NET6.Web.ResultMessages;
using NToastNotify;

namespace NET6.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SeoController : Controller
    {
        private readonly ISeoService seoService;
        private readonly IValidator<Seo> validator;
        private readonly IMapper mapper;
        private readonly IToastNotification toast;

        public SeoController(ISeoService seoService, IValidator<Seo> validator, IMapper mapper, IToastNotification toast)
        {
            this.seoService = seoService;
            this.validator = validator;
            this.mapper = mapper;
            this.toast = toast;
        }
        public async Task<IActionResult> Index()
        {
            var seos = await seoService.GetAllSeosNonDeleted();
            return View(seos);
        }
        public async Task<IActionResult> DeletedSeo()
        {
            var seos = await seoService.GetAllSeosDeleted();
            return View(seos);
        }

        [HttpPost]
        public async Task<IActionResult> AddWithAjax([FromBody] SeoAddDto seoAddDto)
        {
            var map = mapper.Map<Seo>(seoAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await seoService.CreateSeoAsync(seoAddDto);
                toast.AddSuccessToastMessage(Messages.Seo.Add(seoAddDto.Author), new ToastrOptions { Title = "İşlem Başarılı" });

                return Json(Messages.Seo.Add(seoAddDto.Author));
            }
            else
            {
                toast.AddErrorToastMessage(result.Errors.First().ErrorMessage, new ToastrOptions { Title = "İşlem Başarısız" });
                return Json(result.Errors.First().ErrorMessage);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid seoId)
        {
            var seo = await seoService.GetSeoByGuid(seoId);
            var map = mapper.Map<Seo, SeoUpdateDto>(seo);

            return View(map);
        }
        [HttpPost]
        public async Task<IActionResult> Update(SeoUpdateDto seoUpdateDto)
        {
            var map = mapper.Map<Seo>(seoUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var name = await seoService.UpdateSeoAsync(seoUpdateDto);
                toast.AddSuccessToastMessage(Messages.Seo.Update(name), new ToastrOptions { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Seo", new { Area = "Admin" });
            }

            result.AddToModelState(this.ModelState);
            return View();
        }
        public async Task<IActionResult> Delete(Guid seoId)
        {
            var name = await seoService.SafeDeleteSeoAsync(seoId);
            toast.AddSuccessToastMessage(Messages.Seo.Delete(name), new ToastrOptions() { Title = "İşlem Başarılı" });

            return RedirectToAction("Index", "Seo", new { Area = "Admin" });
        }
        public async Task<IActionResult> UndoDelete(Guid seoId)
        {
            var name = await seoService.UndoDeleteSeoAsync(seoId);
            toast.AddSuccessToastMessage(Messages.Seo.Delete(name), new ToastrOptions() { Title = "İşlem Başarılı" });

            return RedirectToAction("Index", "Seo", new { Area = "Admin" });
        }
    }
}