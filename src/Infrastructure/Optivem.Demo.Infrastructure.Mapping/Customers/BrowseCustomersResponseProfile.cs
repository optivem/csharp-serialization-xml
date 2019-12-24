using AutoMapper;
using Optivem.Framework.Core.Domain;
using Optivem.Demo.Core.Application.Customers.Responses;
using Optivem.Demo.Core.Domain.Customers;

namespace Optivem.Demo.Infrastructure.Mapping.Customers
{
    public class BrowseCustomersResponseProfile : Profile
    {
        public BrowseCustomersResponseProfile()
        {
            CreateMap<PageReadModel<CustomerHeaderReadModel>, BrowseCustomersResponse>()
                .ForMember(dest => dest.Records, opt => opt.MapFrom(e => e.Records))
                .ForMember(dest => dest.TotalRecords, opt => opt.MapFrom(e => e.TotalRecords));

            CreateMap<CustomerHeaderReadModel, BrowseCustomersRecordResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(e => e.CustomerId));
        }
    }

    public class BrowseCustomersRecordResponseProfile : Profile
    {
        public BrowseCustomersRecordResponseProfile()
        {
            CreateMap<Customer, BrowseCustomersRecordResponse>();
        }
    }
}