using RiseFood.Core.DomainObjects;

namespace RiseFood.ProductList.Domain
{
    public class Category : Entity
    {
        public Category(int code, string name)
        {
            Code = code;
            Name = name;
        }
        
        public int Code { get; private set; }
        public string Name { get; private set; }

        public override void Validate()
        {
            Validations.ValidateIfEmpty(Name, "The name can't be empty or null.");
        }
        
    }
}