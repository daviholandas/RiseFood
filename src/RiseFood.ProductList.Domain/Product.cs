using System.Collections.Generic;
using RiseFood.Core.DomainObjects;

namespace RiseFood.ProductList.Domain
{
    public class Product : Entity, IAggregateRoot
    {
        public Product(string code, string name, decimal price, string description, Size? size, Category category, HashSet<string> additionalProducts)
        {
            Code = code;
            Name = name;
            Price = price;
            Description = description;
            Size = size ?? Size.Standard;
            Category = category;
            AdditionalProducts = additionalProducts ?? new HashSet<string>();
        }
        
        public string Code { get; private set; }
        public string Name  { get; private set; }
        public decimal Price { get; private set; }
        public string Description { get; private set; }
        public Size Size { get; private set; }
        public Category Category { get; private set; }
        public HashSet<string> AdditionalProducts { get; private set; }

        public void AddAdditionalProducts(string additional)
        {
            AdditionalProducts.Add(additional);
        }

        public void ChangeSize(Size size)
        {
            Size = size;
        }

        public override void Validate()
        {
            Validations.ValidateIfEmpty(Name, "The name can't be empty or null");
            Validations.ValidateIfEmpty(Code, "The code can't be null.");
            Validations.ValidateIfNull(Category, "The category can't be null.");
        }
    }
}