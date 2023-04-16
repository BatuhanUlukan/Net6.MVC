using FluentValidation;
using NET6.Entity.Entities;

namespace NET6.Service.FluentValidations
{
    public class SeoValidator : AbstractValidator<Seo>
    {
        public SeoValidator()
        {
            RuleFor(c => c.Author)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(100)
                .WithName("Seo Yazarı");
        }
    }
}