using Microsoft.AspNetCore.Mvc;

namespace NET6.Web.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}