using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using NET6.Entity.DTOs.Histories;
using NET6.Entity.Entities;
using NET6.Service.Extensions;
using NET6.Service.Services.Abstractions;
using NET6.Web.Consts;
using NET6.Web.ResultMessages;


namespace NET6.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HistoryController : Controller
    {
        private readonly IHistoryService historyService;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;
        private readonly IValidator<History> validator;
        private readonly IToastNotification toast;

        public HistoryController(IHistoryService historyService, ICategoryService categoryService, IMapper mapper, IValidator<History> validator, IToastNotification toast)
        {
            this.historyService = historyService;
            this.categoryService = categoryService;
            this.mapper = mapper;
            this.validator = validator;
            this.toast = toast;
        }

        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Index()
        {
            var histories = await historyService.GetAllHistoriesWithCategoryNonDeletedAsync();
            return View(histories);
        }

        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> DeletedHistory()
        {
            var histories = await historyService.GetAllHistoriesWithCategoryDeletedAsync();
            return View(histories);
        }

        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Add()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new HistoryAddDto { Categories = categories });
        }

        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Add(HistoryAddDto historyAddDto)
        {
            var map = mapper.Map<History>(historyAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await historyService.CreateHistoryAsync(historyAddDto);
                toast.AddSuccessToastMessage(Messages.History.Add(historyAddDto.Title), new ToastrOptions { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "History", new { Area = "Admin" });
            }
            else
            {
                result.AddToModelState(this.ModelState);
            }

            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new HistoryAddDto { Categories = categories });


        }


        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(Guid historyId)
        {
            var history = await historyService.GetHistoryWithCategoryNonDeletedAsync(historyId);
            var categories = await categoryService.GetAllCategoriesNonDeleted();

            var historyUpdateDto = mapper.Map<HistoryUpdateDto>(history);
            historyUpdateDto.Categories = categories;

            return View(historyUpdateDto);
        }

        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(HistoryUpdateDto historyUpdateDto)
        {

            var map = mapper.Map<History>(historyUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var title = await historyService.UpdateHistoryAsync(historyUpdateDto);
                toast.AddSuccessToastMessage(Messages.History.Update(title), new ToastrOptions() { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "History", new { Area = "Admin" });

            }
            else
            {
                result.AddToModelState(this.ModelState);
            }


            var categories = await categoryService.GetAllCategoriesNonDeleted();
            historyUpdateDto.Categories = categories;
            return View(historyUpdateDto);
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Delete(Guid historyId)
        {
            var title = await historyService.SafeDeleteHistoryAsync(historyId);
            toast.AddSuccessToastMessage(Messages.History.Delete(title), new ToastrOptions() { Title = "İşlem Başarılı" });


            return RedirectToAction("Index", "History", new { Area = "Admin" });
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> UndoDelete(Guid historyId)
        {
            var title = await historyService.UndoDeleteHistoryAsync(historyId);
            toast.AddSuccessToastMessage(Messages.History.UndoDelete(title), new ToastrOptions() { Title = "İşlem Başarılı" });


            return RedirectToAction("Index", "History", new { Area = "Admin" });
        }
    }
}
