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
        
        public async Task<IEnumerable<Supply>> ListSupplies()
        {
            return _mapper.Map<IEnumerable<Supply>>( await _suppliesService.GetAllInsumos());
        }

        public async Task<IEnumerable<Supply>> ListSuppliesByCategory(string categoryName)
        {
            return _mapper.Map<IEnumerable<Supply>>(await _suppliesService.GetAllInsumosByCategory(categoryName));
        }

        public async Task<IEnumerable<object>> ListSuppliesCategories()
        {
            return await _suppliesService.ListCategories();
        }
    }
}