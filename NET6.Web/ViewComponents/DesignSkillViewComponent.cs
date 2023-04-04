using Microsoft.AspNetCore.Mvc;
using NET6.Service.Services.Abstractions;

namespace NET6.Web.ViewComponents
{
    public class DesignSkillViewComponent : ViewComponent
    {
        private readonly ISkillService skillService;
        public DesignSkillViewComponent(ISkillService skillService)
        {
            this.skillService = skillService;
        }
        public async Task<IViewComponentResult> InvokeAsync(Guid? categoryId, bool isAscending = false)
        {
            var skillListDto = await skillService.GetSkillsByCategory(categoryId, isAscending);
            return View(skillListDto);
        }

    }
}
