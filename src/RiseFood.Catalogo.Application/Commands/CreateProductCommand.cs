using System;
using System.Collections.Generic;
using FluentValidation.Results;
using RiseFood.Catalogo.Application.Validations;
using RiseFood.Catalogo.Domain;
using RiseFood.Catalogo.Domain.Enums;
using RiseFood.Core.Messages;

namespace RiseFood.Catalogo.Application.Commands
{
    public class CreateProductCommand : Command
    {
        public CreateProductCommand(string name, decimal price, string description, HashSet<string>ingredientsAdditionals, Sizes size, Guid categoryId)
        {
            Name = name;
            Price = price;
            Description = description;
            _ingredientsAdditionals = ingredientsAdditionals;
            Size = size;
            CategoryId = categoryId;
        }
        private  CreateProductCommand(){}
        
        public string Name {get; private set;}
        public decimal Price {get; private set;}
        public string Description {get; private set;}
        private readonly HashSet<string> _ingredientsAdditionals;
        public Sizes Size {get; private set;}
        public Guid CategoryId {get; private set;}
        

        public override bool IsValid()
        {
            ValidationResult = new CreateProductValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}