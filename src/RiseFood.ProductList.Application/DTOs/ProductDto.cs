using System.Collections.Generic;
using RiseFood.ProductList.Domain;

namespace RiseFood.ProductList.Application.DTOs
{
    public class ProductDto
    {
       public InputProductDto InputProduct { get; set; }
       public string Description { get;  set; }
       public Size Size { get; set; }
       public Category Category { get; set; }
       public HashSet<string> AdditionalProducts { get; set; }
    }
}