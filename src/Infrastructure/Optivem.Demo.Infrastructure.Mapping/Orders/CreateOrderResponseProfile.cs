using AutoMapper;
using Optivem.Demo.Core.Application.Orders.Responses;
using Optivem.Demo.Core.Domain.Orders;

namespace Optivem.Demo.Infrastructure.Mapping.Orders
{
    public class CreateOrderResponseProfile : Profile
    {
        public CreateOrderResponseProfile()
        {
            CreateMap<Order, CreateOrderResponse>()
                .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(e => e.OrderItems));

            CreateMap<OrderItem, CreateOrderItemResponse>();
        }
    }
}