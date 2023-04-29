using Microsoft.AspNetCore.Mvc;

namespace NET6.Web.Controllers
{
    public class ResumeController : Controller
    {
        [HttpGet]
        [Route("resume")]
        public IActionResult Index()
        {
            return View();
        }
    }
}