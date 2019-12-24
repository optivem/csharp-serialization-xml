using AutoMapper;
using Optivem.Demo.Core.Application.Products.Responses;
using Optivem.Demo.Core.Domain.Products;

namespace Optivem.Demo.Infrastructure.Mapping.Products
{
    public class CreateProductResponseProfile : Profile
    {
        public CreateProductResponseProfile()
        {
            CreateMap<Product, CreateProductResponse>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(e => e.ProductCode))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(e => e.ProductName))
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(e => e.ListPrice));
        }
    }
}