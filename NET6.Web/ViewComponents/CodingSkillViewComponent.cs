using Microsoft.AspNetCore.Mvc;
using NET6.Service.Services.Abstractions;
using NET6.Service.Services.Concrete;

namespace NET6.Web.ViewComponents
{
    public class CodingSkillViewComponent : ViewComponent
    {
        private readonly ISkillService skillService;
        public CodingSkillViewComponent(ISkillService skillService)
        {
            this.skillService = skillService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var skills = await skillService.GetAllSkillsWithCategoryNonDeletedAsync();
            return View(skills);
        }
    }
}
