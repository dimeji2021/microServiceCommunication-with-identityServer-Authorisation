using AutoMapper;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.Dtos;

namespace Mango.Services.ProductAPI
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
        }
    }
}
