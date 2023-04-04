using Microsoft.AspNetCore.Mvc;
using NET6.Service.Services.Abstractions;

namespace NET6.Web.ViewComponents
{
    public class EduHistoryViewComponent : ViewComponent
    {
        private readonly IHistoryService historyService;
        public EduHistoryViewComponent(IHistoryService historyService)
        {
            this.historyService = historyService;
        }
        public async Task<IViewComponentResult> InvokeAsync(Guid? categoryId, bool isAscending = false)
        {
            var historyListDto = await historyService.GetHistoriesByCategory(categoryId, isAscending);
            return View(historyListDto);
        }

    }
}
