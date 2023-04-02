using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using NET6.Service.FluentValidations;
using NET6.Service.Helpers.Images;
using NET6.Service.Services.Abstractions;
using NET6.Service.Services.Concrete;
using System.Globalization;
using System.Reflection;

namespace NET6.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IImageHelper, ImageHelper>();
            services.AddScoped<IDashbordService, DashboardService>();
            services.AddScoped<IPortfolioService, PortfolioService>();
            services.AddScoped<IHistoryService, HistoryService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<ITestimonialService, TestimonialService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddAutoMapper(assembly);


            services.AddControllersWithViews()
                .AddFluentValidation(opt =>
                {
                    opt.RegisterValidatorsFromAssemblyContaining<ArticleValidator>();
                    opt.DisableDataAnnotationsValidation = true;
                    opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
                });
            services.AddControllersWithViews()
                .AddFluentValidation(opt =>
                {
                    opt.RegisterValidatorsFromAssemblyContaining<PortfolioValidator>();
                    opt.DisableDataAnnotationsValidation = true;
                    opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
                });
            services.AddControllersWithViews()
                .AddFluentValidation(opt =>
                {
                    opt.RegisterValidatorsFromAssemblyContaining<HistoryValidator>();
                    opt.DisableDataAnnotationsValidation = true;
                    opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
                });
            services.AddControllersWithViews()
              .AddFluentValidation(opt =>
              {
                  opt.RegisterValidatorsFromAssemblyContaining<TestimonialValidator>();
                  opt.DisableDataAnnotationsValidation = true;
                  opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
              }); services.AddControllersWithViews()
              .AddFluentValidation(opt =>
              {
                  opt.RegisterValidatorsFromAssemblyContaining<AboutValidator>();
                  opt.DisableDataAnnotationsValidation = true;
                  opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
              });

            return services;
        }
    }
}





