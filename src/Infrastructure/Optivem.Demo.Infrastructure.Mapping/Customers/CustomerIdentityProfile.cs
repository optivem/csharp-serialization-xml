using AutoMapper;
using Optivem.Demo.Core.Domain.Customers;
using System;

namespace Optivem.Demo.Infrastructure.Mapping.Customers
{
    public class CustomerIdentityProfile : Profile
    {
        public CustomerIdentityProfile()
        {
            CreateMap<CustomerIdentity, Guid>()
                .ConvertUsing(src => src.Value);
        }
    }
}