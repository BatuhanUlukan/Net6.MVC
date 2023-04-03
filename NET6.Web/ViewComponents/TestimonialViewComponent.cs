using Microsoft.AspNetCore.Mvc;
using NET6.Service.Services.Abstractions;


namespace NET6.Web.ViewComponents
{
    public class TestimonialViewComponent : ViewComponent
    {
        private readonly ITestimonialService testimonialService;
        public TestimonialViewComponent(ITestimonialService testimonialService)
        {
            this.testimonialService = testimonialService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var testimonials = await testimonialService.GetAllByPagingAsync();
            return View(testimonials);
        }
    }
}
