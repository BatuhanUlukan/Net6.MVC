using Microsoft.AspNetCore.Mvc;
using NET6.Data.UnitOfWorks;
using NToastNotify;
using NET6.Entity.DTOs.Email;
using NET6.Service.Services.Abstractions;
using System.Net.Mail;
using System.Net;
using NET6.Entity.Entities;

namespace NET6.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAboutService aboutService;
        private readonly IToastNotification toastNotification;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IUnitOfWork unitOfWork;
        private readonly IEmailService mailService;

        public HomeController(ILogger<HomeController> logger, IEmailService mailService, IAboutService aboutService, IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            this.aboutService = aboutService;
            this.mailService = mailService;
            this.httpContextAccessor = httpContextAccessor;
            this.unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            var abouts = await aboutService.GetAllByPagingAsync();
            return View(abouts);
        }
        [HttpPost("sendEmail")]
        public async Task<IActionResult> SendMail([FromForm] EmailInfoDto emailInfo)
        {
            try
            {
                await mailService.SendEmailAsync(emailInfo);
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpPost("sendEmailTemplate")]
        public async Task<IActionResult> SendWelcomeMail([FromForm] EmailSourceDto source)
        {
            try
            {
                await mailService.SendEmailTemplateAsync(source);
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }

}


