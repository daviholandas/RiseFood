using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using RiseFood.Gestor.Application.DTOs;
using RiseFood.Gestor.Domain;

namespace RiseFood.Gestor.Application.Services
{
    public class SupplieAppService : ISupplieAppService
    {
        private readonly ISupplieRepository _supplieRepository;
        private readonly IMapper _mappper;

        public SupplieAppService(ISupplieRepository supplieRepository, IMapper mapper)
        {
            _supplieRepository = supplieRepository;
            _mappper = mapper;
        }

        public async Task<IEnumerable<SupplieCategoryDto>> GetAllCatagories()
        {
           return  _mappper.Map<IEnumerable<SupplieCategoryDto>>(await _supplieRepository.GetAllCategories());
        }

        public async Task<IEnumerable<SupplieDto>> GetAllSupplies()
        {
            return _mappper.Map<IEnumerable<SupplieDto>>(await _supplieRepository.GetAllSupplies());
        }

        public async  Task<SupplieDto> GetSupplieByCode(string code)
        {
            return _mappper.Map<SupplieDto>(await _supplieRepository.GetSupplieByCode(code));
        }

        public async  Task<SupplieDto> GetSupplieById(int id)
        {
           return _mappper.Map<SupplieDto>(await _supplieRepository.GetSupplieById(id));
        }

        public async Task<IEnumerable<SupplieDto>> GetSuppliesByCategory(string categoryCode)
        {
            return _mappper.Map<IEnumerable<SupplieDto>>(await _supplieRepository.GetSuppliesByCategory(categoryCode));
        }

        public void Dispose()
        {
            _supplieRepository?.Dispose();
        }
    }
}
