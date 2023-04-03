using Microsoft.AspNetCore.Mvc;

namespace NET6.Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
