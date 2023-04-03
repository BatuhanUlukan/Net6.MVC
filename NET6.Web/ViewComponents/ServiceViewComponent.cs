using Microsoft.AspNetCore.Mvc;
using NET6.Service.Services.Abstractions;


namespace NET6.Web.ViewComponents
{
    public class ServiceViewComponent : ViewComponent
    {
        private readonly IProcessService processService;
        public ServiceViewComponent(IProcessService processService)
        {
            this.processService = processService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var history = await processService.GetAllByPagingAsync();
            return View(history);
        }
    }
}
