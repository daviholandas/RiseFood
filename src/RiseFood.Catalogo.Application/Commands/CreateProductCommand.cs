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
        public CreateProductCommand(string name, decimal price, string description, HashSet<string>ingredientsAdditionals, Sizes size, DateTime createDate, Guid categoryId)
        {
            Name = name;
            Price = price;
            Description = description;
            IngredientsAdditionals = ingredientsAdditionals;
            Size = size;
            CreateDate = createDate;
            CategoryId = categoryId;
        }
        private  CreateProductCommand(){}
        
        public int Code { get; set; }
        public string Name {get; set;}
        public decimal Price {get; set;}
        public string Description {get; set;}
        public  HashSet<string> IngredientsAdditionals { get; set; }
        public Sizes Size {get; set;}
        public DateTime CreateDate { get; set; }
        public Guid CategoryId { get; set; }
        


        public override bool IsValid()
        {
            ValidationResult = new CreateProductValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}