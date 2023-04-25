using Microsoft.AspNetCore.Mvc;
using NET6.Service.Services.Abstractions;

namespace NET6.Web.ViewComponents
{
    public class HomeSocialViewComponent : ViewComponent
    {
        private readonly ISocialService socialService;

        public HomeSocialViewComponent(ISocialService socialService)
        {

            this.socialService = socialService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var socials = await socialService.GetAllSocialsNonDeleted();

            return View(socials);
        }
    }
}
