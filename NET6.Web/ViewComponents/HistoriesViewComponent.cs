using Microsoft.AspNetCore.Mvc;
using NET6.Service.Services.Abstractions;

namespace NET6.Web.ViewComponents
{
    public class HistoriesViewComponent : ViewComponent
    {
        private readonly IHistoryService historyService;
        public HistoriesViewComponent(IHistoryService historyService)
        {
            this.historyService = historyService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string categoryName, bool isAscending = false)
        {
            var historyListDto = await historyService.GetSkillsByCategoryName(categoryName, isAscending);
            return View(historyListDto);
        }

    }
}