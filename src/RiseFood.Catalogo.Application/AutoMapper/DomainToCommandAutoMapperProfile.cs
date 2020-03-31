using AutoMapper;
using RiseFood.Catalogo.Application.Commands;
using RiseFood.Catalogo.Domain;

namespace RiseFood.Catalogo.Application.AutoMapper
{
    public class DomainToCommandAutoMapperProfile : Profile
    {
        public DomainToCommandAutoMapperProfile()
        {
            CreateMap<Product, CreateProductCommand>();
            CreateMap<Category, CreateCategoryCommand>();
        }
    }
}