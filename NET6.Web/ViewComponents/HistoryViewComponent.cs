using Microsoft.AspNetCore.Mvc;
using NET6.Service.Services.Abstractions;


namespace NET6.Web.ViewComponents
{
    public class HistoryViewComponent : ViewComponent
    {
        private readonly IHistoryService historyService;
        public HistoryViewComponent(IHistoryService historyService)
        {
            this.historyService = historyService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var history = await historyService.GetAllHistoriesWithCategoryNonDeletedAsync();
            return View(history);
        }
    }
}
