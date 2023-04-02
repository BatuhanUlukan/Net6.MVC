using FluentValidation;
using NET6.Entity.Entities;

namespace NET6.Service.FluentValidations
{

    public class TestimonialValidator : AbstractValidator<Testimonial>
    {
        public TestimonialValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(150)
                .WithName("Başlık");

        }
    }
}
