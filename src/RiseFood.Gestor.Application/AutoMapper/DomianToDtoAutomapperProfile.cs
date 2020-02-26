using System;
using AutoMapper;
using RiseFood.Gestor.Application.DTOs;
using RiseFood.Gestor.Domain;

namespace RiseFood.Gestor.Application.AutoMapper
{
    public class DomianToDtoAutomapperProfile : Profile
    {
        public DomianToDtoAutomapperProfile()
        {
            CreateMap<Supplie, SupplieDto>();
            CreateMap<SupplieCategory, SupplieCategoryDto>();
        }
    }
}
