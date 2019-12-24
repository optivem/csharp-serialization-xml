using AutoMapper;
using Optivem.Demo.Core.Application.Orders.Responses;
using Optivem.Demo.Core.Domain.Orders;

namespace Optivem.Demo.Infrastructure.Mapping.Orders
{
    public class UpdateOrderResponseProfile : Profile
    {
        public UpdateOrderResponseProfile()
        {
            CreateMap<Order, UpdateOrderResponse>()
                .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(e => e.OrderItems));

            CreateMap<OrderItem, UpdateOrderItemResponse>();
        }
    }
}
