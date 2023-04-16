using Microsoft.AspNetCore.Mvc;

namespace NET6.Web.ViewComponents
{
    public class CssViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
