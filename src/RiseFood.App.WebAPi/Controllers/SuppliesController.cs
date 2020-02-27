using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RiseFood.Gestor.Application.DTOs;
using RiseFood.Gestor.Application.Services;

namespace RiseFood.App.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class SuppliesController : MainConttroller
    {
        private readonly ISupplieAppService _supplieService;

        public SuppliesController(ISupplieAppService supplieService)
        {
            _supplieService = supplieService;
        }

        [HttpGet]
        public async  Task<IEnumerable<SupplieDto>> GetAll()
        {
           return await _supplieService.GetAllSupplies();
        }

        [HttpGet]
        [Route("categories")]
        public async Task<IEnumerable<SupplieCategoryDto>> GetAllCategories()
        {
            return await _supplieService.GetAllCatagories();
        }

        [HttpGet]
        [Route("categories/{categoryCode=string}")]
        public async Task<IEnumerable<SupplieDto>> GetSuppliesByCategories(string categoryCode)
        {
            return await _supplieService.GetSuppliesByCategory(categoryCode);
        }
    }
}
