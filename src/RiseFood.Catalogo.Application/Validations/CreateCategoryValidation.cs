using FluentValidation;
using RiseFood.Catalogo.Application.Commands;

namespace RiseFood.Catalogo.Application.Validations
{
    public class CreateCategoryValidation : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryValidation()
        {
            RuleFor(c => c.Code)
                .NotNull()
                .WithMessage("The code can't be null.")
                .NotEqual(0)
                .WithMessage("The code is invalid.");

            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage("The name can't be empty.");
        }
    }
}