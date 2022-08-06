using AutoMapper;
using CJK.Service.ProductAPI.Model;
using CJK.Service.ProductAPI.Model.Dto;

namespace CJK.Service.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                ////có thể đảo ngược map bằng ReverseMap
                //cf.CreateMap<Product, ProductDto>().ReverseMap();
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });
            return mappingConfig;
        }
    }
}
