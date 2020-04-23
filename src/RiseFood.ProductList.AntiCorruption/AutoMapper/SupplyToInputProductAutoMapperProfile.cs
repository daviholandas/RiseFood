using AutoMapper;
using RiseFood.ProductList.Domain;

namespace RiseFood.ProductList.AntiCorruption.AutoMapper
{
    public class SupplyToInputProductAutoMapperProfile : Profile
    {
        public SupplyToInputProductAutoMapperProfile()
        {
            CreateMap<Supply, InputProductDto>().ReverseMap();
        }
    }                                                                                                                                                                                          
}