using Microsoft.AspNetCore.Mvc;
using NET6.Service.Services.Abstractions;


namespace NET6.Web.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly IAboutService aboutService;
        public HeaderViewComponent(IAboutService aboutService)
        {
            this.aboutService = aboutService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var abouts = await aboutService.GetAllAboutsNonDeletedAsync();
            return View(abouts);
        }
    }
}
