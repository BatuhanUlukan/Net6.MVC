using Microsoft.AspNetCore.Mvc;
using NET6.Data.UnitOfWorks;
using NET6.Entity.DTOs.Abouts;
using NET6.Entity.Entities;
using NET6.Service.Services.Abstractions;
using NET6.Service.Services.Concrete;

namespace NET6.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAboutService aboutService;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IUnitOfWork unitOfWork;

        public HomeController(ILogger<HomeController> logger, IAboutService aboutService, IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            this.aboutService = aboutService;
            this.httpContextAccessor = httpContextAccessor;
            this.unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            var abouts = await aboutService.GetAllByPagingAsync();
            return View(abouts);
        }

    }
}
