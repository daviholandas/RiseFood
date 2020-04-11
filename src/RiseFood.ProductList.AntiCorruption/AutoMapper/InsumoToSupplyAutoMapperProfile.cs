using AutoMapper;
using RiseFood.ProductList.AntiCorruption;
using RiseFood.ProductList.Domain;

namespace RiseFood.ProductList.Application.AutoMapper
{
    public class InsumoToSupplyAutoMapperProfile : Profile
    {
        public InsumoToSupplyAutoMapperProfile()
        {
            CreateMap<Insumos, Supply>().ReverseMap();
        }
    }                                                                                                                                                                                          
}