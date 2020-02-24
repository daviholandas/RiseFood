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
        public Product(string productName, decimal price, string description, HashSet<string> ingredientsAdditionals, Sizes? size, Guid categoryId)
        {
            ProductName = productName;
            Price = price;
            Description = description;
            IngredientsAdditionals = ingredientsAdditionals ?? new HashSet<string>();
            Size = size ?? Sizes.Standard;
            CategoryId = categoryId;
            
            Validate();
        }

        public string ProductName {get; private set;}
        public decimal Price {get; private set;}
        public Category Category {get; private set;}
        public string Description {get; private set;}
        public HashSet<string> IngredientsAdditionals {get; private set;}
        public Sizes Size {get; private set;}

        //EF Relations
        public Guid CategoryId {get; private set;}


        public override void Validate()
        {
            Validations.ValidateIfEmpty(ProductName, "The name of product can't be empty or null.");
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
            IngredientsAdditionals.Add(ingredient);
        }
    }
}
