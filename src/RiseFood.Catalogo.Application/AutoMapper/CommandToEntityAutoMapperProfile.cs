using System.Collections.Generic;
using AutoMapper;
using RiseFood.Catalogo.Application.Commands;
using RiseFood.Catalogo.Domain;

namespace RiseFood.Catalogo.Application.AutoMapper
{
    public class CommandToEntityAutoMapperProfile : Profile
    {
        public CommandToEntityAutoMapperProfile()
        {
            CreateMap<CreateProductCommand, Product>()
                .ConstructUsing(p => 
                    new Product(p.Code, p.Name, p.Price, 
                        p.Description, p.IngredientsAdditionals, p.Size, p.CreateDate, p.CategoryId)
                );

            CreateMap<CreateCategoryCommand, Category>()
                .ConstructUsing(c => new Category(c.Code, c.Name));
        }
    }
}