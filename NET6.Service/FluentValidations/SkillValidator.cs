using FluentValidation;
using NET6.Entity.Entities;


namespace NET6.Service.FluentValidations
{
    public class SkillValidator : AbstractValidator<Skill>
    {
        public SkillValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(150)
                .WithName("Başlık");

            RuleFor(x => x.Percent)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2)
                .MaximumLength(5)
                .WithName("Değer");


        }

    }

}
