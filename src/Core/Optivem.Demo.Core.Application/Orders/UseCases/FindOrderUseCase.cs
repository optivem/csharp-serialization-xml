﻿using System.Threading.Tasks;
using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Application.Mapping;
using Optivem.Demo.Core.Application.Orders.Requests;
using Optivem.Demo.Core.Application.Orders.Responses;
using Optivem.Demo.Core.Domain.Orders;

namespace Optivem.Demo.Core.Application.Orders.UseCases
{
    public class FindOrderUseCase : IRequestHandler<FindOrderRequest, FindOrderResponse>
    {
        private readonly IMapper _mapper;
        private readonly IOrderReadRepository _orderReadRepository;

        public FindOrderUseCase(IMapper mapper, IOrderReadRepository orderReadRepository)
        {
            _mapper = mapper;
            _orderReadRepository = orderReadRepository;
        }

        public async Task<FindOrderResponse> HandleAsync(FindOrderRequest request)
        {
            var orderId = new OrderIdentity(request.Id);

            var order = await _orderReadRepository.FindAsync(orderId);

            if (order == null)
            {
                throw new NotFoundRequestException();
            }

            var response = _mapper.Map<Order, FindOrderResponse>(order);
            return response;
        }
    }
}