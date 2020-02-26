using System;
using AutoMapper;
using RiseFood.Gestor.Application.DTOs;
using RiseFood.Gestor.Domain;

namespace RiseFood.Gestor.Application.AutoMapper
{
    public class DtoToDomainAutoMapperProfile : Profile
    {
        public DtoToDomainAutoMapperProfile()
        {
            CreateMap<SupplieDto, Supplie>()
                .ConstructUsing(s => new Supplie(s.Id, s.Code,s.SupplieName, s.Price, s.SupplieCategoryCode));
            
            CreateMap<SupplieCategoryDto, SupplieCategory>()
                .ConstructUsing(c => new SupplieCategory(c.Code, c.CategoryName));
        }
    }
}
