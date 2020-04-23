using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using RiseFood.ProductList.Application;
using RiseFood.ProductList.Domain;

namespace RiseFood.ProductList.AntiCorruption
{
    public class SuppliesServiceFacade : ISuppliesServiceFacade
    {
        private readonly IMapper _mapper;
        private readonly ISuppliesService _suppliesService;

        public SuppliesServiceFacade(IMapper mapper, ISuppliesService suppliesService)
        {
            _mapper = mapper;
            _suppliesService = suppliesService;
        }
        
        public async Task<IEnumerable<InputProductDto>> ListInputProducts()
        {
            return _mapper.Map<IEnumerable<InputProductDto>>( await _suppliesService.GetAllSupplies());
        }

        public async Task<IEnumerable<InputProductDto>> ListInputProductsByCategory(string categoryName)
        {
            return _mapper.Map<IEnumerable<InputProductDto>>(await _suppliesService.GetAllSuppliesByCategory(categoryName));
        }

        public async Task<IEnumerable<object>> ListInputProductsCategories()
        {
            return await _suppliesService.ListCategories();
        }
    }
}