using AutoMapper;
using Krishna.Services.ShoppingCart.Models;
using Krishna.Services.ShoppingCart.Models.Dto;

namespace Krishna.Services.ShoppingCart
{
    public class AutoMapperProfile
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
