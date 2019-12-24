using AutoMapper;
using Optivem.Demo.Core.Domain.Orders;
using System;

namespace Optivem.Demo.Infrastructure.Mapping.Orders
{
    public class OrderIdentityProfile : Profile
    {
        public OrderIdentityProfile()
        {
            CreateMap<OrderIdentity, Guid>()
                .ConvertUsing(src => src.Value);

            CreateMap<OrderItemIdentity, Guid>()
                .ConvertUsing(src => src.Value);
        }
    }
}