using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET6.Service.Services.Abstractions;
using Newtonsoft.Json;

namespace NET6.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;
        private readonly IDashbordService dashbordService;
        private readonly IPortfolioService portfolioService;

        public HomeController(IArticleService articleService, IDashbordService dashbordService, IPortfolioService portfolioService)
        {
            this.articleService = articleService;
            this.dashbordService = dashbordService;
            this.portfolioService = portfolioService;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticlesWithCategoryNonDeletedAsync();

            return View(articles);
        }
        [HttpGet]
        public async Task<IActionResult> YearlyArticleCounts()
        {
            var count = await dashbordService.GetYearlyArticleCounts();
            return Json(JsonConvert.SerializeObject(count));
        }
        [HttpGet]
        public async Task<IActionResult> TotalArticleCount()
        {
            var count = await dashbordService.GetTotalArticleCount();
            return Json(count);
        }
        [HttpGet]
        public async Task<IActionResult> TotalCategoryCount()
        {
            var count = await dashbordService.GetTotalCategoryCount();
            return Json(count);
        }            [HttpGet]
        public async Task<IActionResult> TotalPortfolioCount()
        {
            var count = await dashbordService.GetTotalPortfolioCount();
            return Json(count);
        }    
        public async Task<IActionResult> TotalServiceCount()
        {
            var count = await dashbordService.GetTotalServiceCount();
            return Json(count);
        }
    }
}
