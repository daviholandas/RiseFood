using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RiseFood.Gestor.Application.DTOs;

namespace RiseFood.Gestor.Application.Services
{
    public interface ISupplieAppService : IDisposable
    {
        Task<IEnumerable<SupplieDto>> GetAllSupplies();
        Task<SupplieDto> GetSupplieById(int id);
        Task<SupplieDto> GetSupplieByCode(string code);
        Task<IEnumerable<SupplieDto>> GetSuppliesByCategory(string categoryCode);
        Task<IEnumerable<SupplieCategoryDto>> GetAllCatagories();
    }
}
