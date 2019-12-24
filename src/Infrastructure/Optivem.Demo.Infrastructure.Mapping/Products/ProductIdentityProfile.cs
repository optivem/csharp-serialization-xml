using AutoMapper;
using Optivem.Demo.Core.Domain.Products;
using System;

namespace Optivem.Demo.Infrastructure.Mapping.Products
{
    public class ProductIdentityProfile : Profile
    {
        public ProductIdentityProfile()
        {
            CreateMap<ProductIdentity, Guid>()
                .ConvertUsing(src => src.Value);
        }
    }
}