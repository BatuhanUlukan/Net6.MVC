using FluentValidation;
using NET6.Entity.Entities;

namespace NET6.Service.FluentValidations
{
    public class MainValidator : AbstractValidator<Main>
    {
        public MainValidator()
        {
            RuleFor(c => c.Job)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(100)
                .WithName("Kategori Adı");
            RuleFor(c => c.Title)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(100)
                .WithName("İsim");
            RuleFor(c => c.Content)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(100)
                .WithName("İçerik");
        }
    }
}
