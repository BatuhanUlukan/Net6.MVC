using Microsoft.AspNetCore.Mvc;
using NET6.Service.Services.Abstractions;

namespace NET6.Web.ViewComponents
{
    public class SkillsViewComponent : ViewComponent
    {
        private readonly ISkillService skillService;
        public SkillsViewComponent(ISkillService skillService)
        {
            this.skillService = skillService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string categoryName, bool isAscending = false)
        {
            var skillListDto = await skillService.GetSkillsByCategoryName(categoryName, isAscending);
            return View(skillListDto);
        }

    }
}