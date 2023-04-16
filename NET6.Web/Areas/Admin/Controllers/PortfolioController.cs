using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET6.Entity.DTOs.Articles;
using NET6.Entity.DTOs.Portfolios;
using NET6.Entity.Entities;
using NET6.Service.Extensions;
using NET6.Service.Services.Abstractions;
using NET6.Web.Consts;
using NET6.Web.ResultMessages;
using NToastNotify;



namespace NET6.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService portfolioService;
        private readonly ICategoryService categoryService;
        private readonly ISeoService seoService;
        private readonly IMapper mapper;
        private readonly IValidator<Portfolio> validator;
        private readonly IToastNotification toast;

        public PortfolioController(IPortfolioService portfolioService, ICategoryService categoryService, ISeoService seoService, IMapper mapper, IValidator<Portfolio> validator, IToastNotification toast)
        {
            this.portfolioService = portfolioService;
            this.categoryService = categoryService;
            this.seoService = seoService;
            this.mapper = mapper;
            this.validator = validator;
            this.toast = toast;
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}, {RoleConsts.User}")]
        public async Task<IActionResult> Index()
        {
            var portfolios = await portfolioService.GetAllPortfoliosWithCategoryNonDeletedAsync();
            return View(portfolios);
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> DeletedPortfolio()
        {
            var portfolios = await portfolioService.GetAllPortfoliosWithCategoryDeletedAsync();
            return View(portfolios);
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Add()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            var seos = await seoService.GetAllSeosNonDeleted();
            var portfolioAddDto = new PortfolioAddDto
            {
                Categories = categories,
                Seos = seos
            };
            return View(portfolioAddDto);

        }
        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Add(PortfolioAddDto portfolioAddDto)
        {

            var map = mapper.Map<Portfolio>(portfolioAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await portfolioService.CreatePortfolioAsync(portfolioAddDto);
                toast.AddSuccessToastMessage(Messages.Portfolio.Add(portfolioAddDto.Title), new ToastrOptions { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Portfolio", new { Area = "Admin" });
            }
            else
            {
                result.AddToModelState(this.ModelState);
            }

            var categories = await categoryService.GetAllCategoriesNonDeleted();
            var seos = await seoService.GetAllSeosNonDeleted();
            return View(new PortfolioAddDto { Categories = categories, Seos = seos });
        }

        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(Guid portfolioId)
        {
            var portfolio = await portfolioService.GetPortfolioWithCategoryNonDeletedAsync(portfolioId);
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            var seos = await seoService.GetAllSeosNonDeleted();

            var portfolioUpdateDto = mapper.Map<PortfolioUpdateDto>(portfolio);

            portfolioUpdateDto.Categories = categories;
            portfolioUpdateDto.Seos = seos;


            return View(portfolioUpdateDto);
        }
        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(PortfolioUpdateDto portfolioUpdateDto)
        {

            var map = mapper.Map<Portfolio>(portfolioUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var title = await portfolioService.UpdatePortfolioAsync(portfolioUpdateDto);
                toast.AddSuccessToastMessage(Messages.Portfolio.Update(title), new ToastrOptions() { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Portfolio", new { Area = "Admin" });

            }
            else
            {
                result.AddToModelState(this.ModelState);
            }


            var categories = await categoryService.GetAllCategoriesNonDeleted();
            var seos = await seoService.GetAllSeosNonDeleted();
            portfolioUpdateDto.Categories = categories;
            portfolioUpdateDto.Seos = seos;
            return View(portfolioUpdateDto);
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Delete(Guid portfolioId)
        {
            var title = await portfolioService.SafeDeletePortfolioAsync(portfolioId);
            toast.AddSuccessToastMessage(Messages.Portfolio.Delete(title), new ToastrOptions() { Title = "İşlem Başarılı" });


            return RedirectToAction("Index", "Portfolio", new { Area = "Admin" });
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> UndoDelete(Guid portfolioId)
        {
            var title = await portfolioService.UndoDeletePortfolioAsync(portfolioId);
            toast.AddSuccessToastMessage(Messages.Portfolio.UndoDelete(title), new ToastrOptions() { Title = "İşlem Başarılı" });


            return RedirectToAction("Index", "Portfolio", new { Area = "Admin" });
        }
    }
}