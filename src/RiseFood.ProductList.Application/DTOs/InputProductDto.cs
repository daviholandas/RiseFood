using RiseFood.Core.DomainObjects;

namespace RiseFood.ProductList.Domain
{
    public class InputProductDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}