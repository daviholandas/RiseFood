using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RiseFood.ProductList.Application.Services;
using RiseFood.ProductList.Domain;

namespace RiseFood.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : MainController
    {
        private readonly IListInputProductService _listInputProductService;

        public ProductsController(IListInputProductService listInputProductsService)
        {
            _listInputProductService = listInputProductsService;
        }
        
        [Route("supplies/categories")]
        [HttpGet]
        public async Task<IEnumerable<object>> ListCategoriesSupplies()
        {
            return await _listInputProductService.ListInputProductCategories();
        }

        [Route("supplies")]
        [HttpGet]
        public async Task<IEnumerable<InputProductDto>> ListAllSupplies() => await _listInputProductService.ListInputProducts();

        [HttpGet("supplies/{category=string}")]
        public async Task<IEnumerable<InputProductDto>> ListAllSuppliesByCategory(string category) =>
            await _listInputProductService.ListInputProductsBySupplyCategory(category);
    }
}