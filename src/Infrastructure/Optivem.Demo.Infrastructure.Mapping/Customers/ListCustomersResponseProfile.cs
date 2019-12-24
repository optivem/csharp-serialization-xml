﻿using AutoMapper;
using Optivem.Framework.Core.Domain;
using Optivem.Demo.Core.Application.Customers.Responses;
using Optivem.Demo.Core.Domain.Customers;

namespace Optivem.Demo.Infrastructure.Mapping.Customers
{
    public class ListCustomersResponseProfile : Profile
    {
        public ListCustomersResponseProfile()
        {
            CreateMap<ListReadModel<CustomerIdNameReadModel>, ListCustomersResponse>()
                .ForMember(dest => dest.Records, opt => opt.MapFrom(e => e.Records))
                .ForMember(dest => dest.TotalRecords, opt => opt.MapFrom(e => e.TotalRecords));

            CreateMap<CustomerIdNameReadModel, ListCustomersRecordResponse>();
        }
    }

    public class ListCustomersRecordResponseProfile : Profile
    {
        public ListCustomersRecordResponseProfile()
        {
            CreateMap<Customer, ListCustomersRecordResponse>();
        }
    }
}