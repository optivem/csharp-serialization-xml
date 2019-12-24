﻿using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Application.Mapping;
using Optivem.Framework.Core.Domain;
using Optivem.Demo.Core.Application.Orders.Requests;
using Optivem.Demo.Core.Application.Orders.Responses;
using Optivem.Demo.Core.Domain.Orders;
using System.Threading.Tasks;

namespace Optivem.Demo.Core.Application.Orders.UseCases
{
    public class ListOrdersUseCase : IRequestHandler<ListOrdersRequest, ListOrdersResponse>
    {
        private readonly IMapper _mapper;
        private readonly IOrderReadRepository _orderReadRepository;

        public ListOrdersUseCase(IMapper mapper, IOrderReadRepository orderReadRepository)
        {
            _mapper = mapper;
            _orderReadRepository = orderReadRepository;
        }

        public async Task<ListOrdersResponse> HandleAsync(ListOrdersRequest request)
        {
            var listResult = await _orderReadRepository.ListAsync();

            return _mapper.Map<ListReadModel<OrderIdNameReadModel>, ListOrdersResponse>(listResult);
        }
    }
}