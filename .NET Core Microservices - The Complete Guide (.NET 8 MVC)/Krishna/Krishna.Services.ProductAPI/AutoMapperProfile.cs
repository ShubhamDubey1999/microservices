using AutoMapper;
using Krishna.Services.ProductAPI.Models;
using Krishna.Services.ProductAPI.Models.Dto;

namespace Krishna.Services.ProductAPI
{
    public class AutoMapperProfile
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Product, ProductDto>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
