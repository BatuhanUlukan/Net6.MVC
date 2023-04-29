using FluentValidation;
using NET6.Entity.Entities;

namespace NET6.Service.FluentValidations
{
    public class LinkValidator : AbstractValidator<Link>
    {
        public LinkValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(100)
                .WithName("Link Adı");
        }
    }
}
