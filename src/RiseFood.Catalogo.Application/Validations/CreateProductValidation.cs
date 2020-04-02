using System;
using FluentValidation;
using RiseFood.Catalogo.Application.Commands;

namespace RiseFood.Catalogo.Application.Validations
{
    public class CreateProductValidation : AbstractValidator<CreateProductCommand>
    {
        public CreateProductValidation()
        {
            RuleFor(p => p.Code)
                .NotNull()
                .WithMessage("The code of product can't null.");
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("The name of product can't empty.");
            RuleFor(p => p.Price)
                .Cascade(CascadeMode.Continue)
                .NotNull()
                .WithMessage("The price of product can't be null.")
                .LessThanOrEqualTo(0)
                .WithMessage("The price of product can't be less than 0(Zero)");
            RuleFor(p => p.CategoryId)
                .NotEqual(Guid.Empty)
                .WithMessage("The category of product can't be null.");
        }
    }
}