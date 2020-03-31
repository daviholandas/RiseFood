using System;
using System.Collections.Generic;
using RiseFood.Catalogo.Domain.Enums;
using RiseFood.Core.BaseClasses;
using RiseFood.Core.DomainObjects;

namespace RiseFood.Catalogo.Domain
{
    public class Product : Entity, IAggregateRoot
    {
        private Product(){}
        public Product(int code, string name, decimal price, string description, HashSet<string> ingredientsAdditionals, Sizes? size, DateTime? createDate, Guid categoryId)
        {
            Code = code;
            Name = name;
            Price = price;
            Description = description;
            _ingredientsAdditionals = ingredientsAdditionals ?? new HashSet<string>();
            Size = size ?? Sizes.Standard;
            CreateDate = createDate ?? DateTime.Today;
            CategoryId = categoryId;
            
            Validate();
        }

        private readonly HashSet<string> _ingredientsAdditionals;
         
        public int Code { get; private set; }
        public string Name {get; private set;}
        public decimal Price {get; private set;}
        public Category Category {get; private set;}
        public string Description {get; private set;}
        public IReadOnlyCollection<string> IngredientsAdditionals => _ingredientsAdditionals;
        public Sizes Size {get; private set;}
        public DateTime CreateDate { get; private set; }

        //EF Relations
        public Guid CategoryId {get; private set;}


        public override void Validate()
        {
            Validations.ValidateIfNull(Code, "The code of product can't be null.");
            Validations.ValidateIfLessThan(Code, 0, "The code of product can't less then 0(zero).");
            Validations.ValidateIfEmpty(Name, "The name of product can't be empty or null.");
            Validations.ValidateIfLessThan(Price,0, "The price of product can't be less than 0(Zero)");
            Validations.ValidateIfNull(CategoryId, "The category of product can't be null.");
        }

        public void ChangeCategory(Category category)
        {
            Category = category;
            CategoryId = category.Id;
        }

        public void ChangeSizeProduct(Sizes size)
        {
            Size = size;
        }

        public void AddIngredients(string ingredient)
        {
            _ingredientsAdditionals.Add(ingredient);
        }
    }
}
