using FluentValidation;
using NET6.Entity.Entities;


namespace NET6.Service.FluentValidations
{
    public class HistoryValidator : AbstractValidator<History>
    {
        public HistoryValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(150)
                .WithName("Başlık");

            RuleFor(x => x.Content)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .WithName("İçerik");


        }

    }

}
