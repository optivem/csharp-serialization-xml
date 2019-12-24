using AutoMapper;
using Optivem.Framework.Core.Domain;
using Optivem.Demo.Core.Application.Products.Responses;
using Optivem.Demo.Core.Domain.Products;

namespace Optivem.Demo.Infrastructure.Mapping.Products
{
    public class ListProductsResponseProfile : Profile
    {
        public ListProductsResponseProfile()
        {
            CreateMap<ListReadModel<ProductIdNameReadModel>, ListProductsResponse>()
                .ForMember(dest => dest.Records, opt => opt.MapFrom(e => e.Records))
                .ForMember(dest => dest.TotalRecords, opt => opt.MapFrom(e => e.TotalRecords));

            CreateMap<ProductIdNameReadModel, ListProductsRecordResponse>();
        }
    }
}