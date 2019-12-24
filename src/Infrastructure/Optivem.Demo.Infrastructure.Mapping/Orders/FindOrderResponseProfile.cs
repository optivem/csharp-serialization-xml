using AutoMapper;
using Optivem.Demo.Core.Application.Orders.Responses;
using Optivem.Demo.Core.Domain.Orders;

namespace Optivem.Demo.Infrastructure.Mapping.Orders
{
    public class FindOrderResponseProfile : Profile
    {
        public FindOrderResponseProfile()
        {
            CreateMap<Order, FindOrderResponse>()
                .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(e => e.OrderItems));

            CreateMap<OrderItem, FindOrderItemResponse>();
        }
    }
}