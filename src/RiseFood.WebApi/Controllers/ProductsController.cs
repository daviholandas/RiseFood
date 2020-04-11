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
        private readonly IListSuppliesService _listSuppliesService;

        public ProductsController(IListSuppliesService listSuppliesService)
        {
            _listSuppliesService = listSuppliesService;
        }
        
        [Route("supplies/categories")]
        [HttpGet]
        public async Task<IEnumerable<object>> ListCategoriesSupplies()
        {
            return await _listSuppliesService.ListInsumosCategories();
        }

        [Route("supplies")]
        [HttpGet]
        public async Task<IEnumerable<Supply>> ListAllSupplies() => await _listSuppliesService.ListSupplies();

        [HttpGet("supplies/{category=string}")]
        public async Task<IEnumerable<Supply>> ListAllSuppliesByCategory(string category) =>
            await _listSuppliesService.ListSuppliesByInsumoCategory(category);
    }
}