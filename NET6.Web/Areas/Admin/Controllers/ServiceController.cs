using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using NET6.Entity.Entities;
using NET6.Service.Extensions;
using NET6.Service.Services.Abstractions;
using NET6.Web.Consts;
using NET6.Web.ResultMessages;
using NET6.Entity.DTOs.Processes;
using NET6.Service.Services.Concrete;


namespace NET6.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly IProcessService processService;
        private readonly IMapper mapper;
        private readonly IValidator<Process> validator;
        private readonly IToastNotification toast;

        public ServiceController(IProcessService processService, IMapper mapper, IValidator<Process> validator, IToastNotification toast)
        {
            this.processService = processService;
            this.mapper = mapper;
            this.validator = validator;
            this.toast = toast;
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}, {RoleConsts.User}")]
        public async Task<IActionResult> Index()
        {
            var processes = await processService.GetAllProcessesNonDeletedAsync();
            return View(processes);
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> DeletedProcess()
        {
            var processes = await processService.GetAllProcessesDeletedAsync();
            return View(processes);
        }


        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(Guid processId)
        {
            var process = await processService.GetProcessesNonDeletedAsync(processId);


            var processUpdateDto = mapper.Map<ProcessUpdateDto>(process);


            return View(processUpdateDto);
        }
        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(ProcessUpdateDto processUpdateDto)
        {

            var map = mapper.Map<Process>(processUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var title = await processService.UpdateProcessAsync(processUpdateDto);
                toast.AddSuccessToastMessage(Messages.Process.Update(title), new ToastrOptions() { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Service", new { Area = "Admin" });

            }
            else
            {
                result.AddToModelState(this.ModelState);
            }

            return View(processUpdateDto);
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Delete(Guid processId)
        {
            var title = await processService.SafeDeleteProcessAsync(processId);
            toast.AddSuccessToastMessage(Messages.Process.Delete(title), new ToastrOptions() { Title = "İşlem Başarılı" });


            return RedirectToAction("Index", "Service", new { Area = "Admin" });
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> UndoDelete(Guid processId)
        {
            var title = await processService.UndoDeleteProcessAsync(processId);
            toast.AddSuccessToastMessage(Messages.Process.UndoDelete(title), new ToastrOptions() { Title = "İşlem Başarılı" });


            return RedirectToAction("Index", "Service", new { Area = "Admin" });
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Add()
        {
            var processes = await processService.GetAllProcessesNonDeletedAsync();
            return View();
        }
        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Add(ProcessAddDto processAddDto)
        {

            var map = mapper.Map<Process>(processAddDto);
            var result = await validator.ValidateAsync(map);


            if (result.IsValid)
            {
                await processService.CreateProcessAsync(processAddDto);
                toast.AddSuccessToastMessage(Messages.Process.Add(processAddDto.Title), new ToastrOptions { Title = "İşlem Başarılı" });

                return RedirectToAction("Index", "Service", new { Area = "Admin" });

            }
            else
            {
                result.AddToModelState(this.ModelState);
            }

            return View();
        }

    }
}
