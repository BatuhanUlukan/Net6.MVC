using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET6.Entity.DTOs.Skills;
using NET6.Entity.Entities;
using NET6.Service.Extensions;
using NET6.Service.Services.Abstractions;
using NET6.Web.Consts;
using NET6.Web.ResultMessages;
using NToastNotify;


namespace NET6.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillController : Controller
    {
        private readonly ISkillService skillService;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;
        private readonly IValidator<Skill> validator;
        private readonly IToastNotification toast;

        public SkillController(ISkillService skillService, ICategoryService categoryService, IMapper mapper, IValidator<Skill> validator, IToastNotification toast)
        {
            this.skillService = skillService;
            this.categoryService = categoryService;
            this.mapper = mapper;
            this.validator = validator;
            this.toast = toast;
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}, {RoleConsts.User}")]
        public async Task<IActionResult> Index()
        {
            var skills = await skillService.GetAllSkillsWithCategoryNonDeletedAsync();
            return View(skills);
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> DeletedProcess()
        {
            var skills = await skillService.GetAllSkillsWithCategoryDeletedAsync();
            return View(skills);
        }


        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(Guid skillId)
        {
            var skill = await skillService.GetSkillWithCategoryNonDeletedAsync(skillId);
            var categories = await categoryService.GetAllCategoriesNonDeleted();

            var skillUpdateDto = mapper.Map<SkillUpdateDto>(skill);
            skillUpdateDto.Categories = categories;

            return View(skillUpdateDto);
        }
        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(SkillUpdateDto skillUpdateDto)
        {

            var map = mapper.Map<Skill>(skillUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var title = await skillService.UpdateSkillAsync(skillUpdateDto);
                toast.AddSuccessToastMessage(Messages.Skill.Update(title), new ToastrOptions() { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Skill", new { Area = "Admin" });

            }
            else
            {
                result.AddToModelState(this.ModelState);
            }


            var categories = await categoryService.GetAllCategoriesNonDeleted();
            skillUpdateDto.Categories = categories;
            return View(skillUpdateDto);
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Delete(Guid skillId)
        {
            var title = await skillService.SafeDeleteSkillAsync(skillId);
            toast.AddSuccessToastMessage(Messages.Skill.Delete(title), new ToastrOptions() { Title = "İşlem Başarılı" });


            return RedirectToAction("Index", "Skill", new { Area = "Admin" });
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> UndoDelete(Guid skillId)
        {
            var title = await skillService.UndoDeleteSkillAsync(skillId);
            toast.AddSuccessToastMessage(Messages.Skill.UndoDelete(title), new ToastrOptions() { Title = "İşlem Başarılı" });


            return RedirectToAction("Index", "Skill", new { Area = "Admin" });
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Add()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new SkillAddDto { Categories = categories });
        }
        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Add(SkillAddDto skillAddDto)
        {

            var map = mapper.Map<Skill>(skillAddDto);
            var result = await validator.ValidateAsync(map);


            if (result.IsValid)
            {
                await skillService.CreateSkillAsync(skillAddDto);
                toast.AddSuccessToastMessage(Messages.Article.Add(skillAddDto.Title), new ToastrOptions { Title = "İşlem Başarılı" });

                return RedirectToAction("Index", "Skill", new { Area = "Admin" });

            }
            else
            {
                result.AddToModelState(this.ModelState);
            }

            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new SkillAddDto { Categories = categories });
        }

    }
}
