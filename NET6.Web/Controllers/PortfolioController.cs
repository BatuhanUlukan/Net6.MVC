using Microsoft.AspNetCore.Mvc;
using NET6.Data.UnitOfWorks;
using NET6.Entity.Entities;
using NET6.Service.Services.Abstractions;
using NET6.Web.Models;
using System.Diagnostics;


namespace NET6.Web.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly ILogger<PortfolioController> _logger;
        private readonly IPortfolioService portfolioService;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IUnitOfWork unitOfWork;

        public PortfolioController(ILogger<PortfolioController> logger, IPortfolioService portfolioService, IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            this.portfolioService = portfolioService;
            this.httpContextAccessor = httpContextAccessor;
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> Index(Guid? categoryId, int currentPage = 1, int pageSize = 3, bool isAscending = false)
        {
            var portfolios = await portfolioService.GetAllByPagingAsync(categoryId, currentPage, pageSize, isAscending);
            return View(portfolios);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Route("Portfolio/{title}/{id}")]
        public async Task<IActionResult> Detail(Guid id)
        {
            var ipAddress = httpContextAccessor.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
            var portfolioVisitors = await unitOfWork.GetRepository<PortfolioVisitor>().GetAllAsync(null, x => x.Visitor, y => y.Portfolio);
            var portfolio = await unitOfWork.GetRepository<Portfolio>().GetAsync(x => x.Id == id);

            var result = await portfolioService.GetPortfolioWithCategoryNonDeletedAsync(id);

            var visitor = await unitOfWork.GetRepository<Visitor>().GetAsync(x => x.IpAddress == ipAddress);

            var addPortfolioVisitors = new PortfolioVisitor(portfolio.Id, visitor.Id);

            if (portfolioVisitors.Any(x => x.VisitorId == addPortfolioVisitors.VisitorId && x.PortfolioId == addPortfolioVisitors.PortfolioId))
                return View(result);
            else
            {
                await unitOfWork.GetRepository<PortfolioVisitor>().AddAsync(addPortfolioVisitors);
                portfolio.ViewCount += 1;
                await unitOfWork.GetRepository<Portfolio>().UpdateAsync(portfolio);
                await unitOfWork.SaveAsync();
            }

            return View(result);
        }
    }
}