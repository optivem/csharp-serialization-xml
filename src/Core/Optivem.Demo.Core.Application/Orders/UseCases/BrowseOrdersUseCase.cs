﻿using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Application.Mapping;
using Optivem.Framework.Core.Domain;
using Optivem.Demo.Core.Application.Orders.Requests;
using Optivem.Demo.Core.Application.Orders.Responses;
using Optivem.Demo.Core.Domain.Orders;
using System.Threading.Tasks;

namespace Optivem.Demo.Core.Application.Orders.UseCases
{
    public class BrowseOrdersUseCase : IRequestHandler<BrowseOrdersRequest, BrowseOrdersResponse>
    {
        private readonly IMapper _mapper;
        private readonly IOrderReadRepository _orderReadRepository;

        public BrowseOrdersUseCase(IMapper mapper, IOrderReadRepository orderReadRepository)
        {
            _mapper = mapper;
            _orderReadRepository = orderReadRepository;
        }

        public async Task<BrowseOrdersResponse> HandleAsync(BrowseOrdersRequest request)
        {
            var pageQuery = new PageQuery(request.Page, request.Size);
            var pageResult = await _orderReadRepository.GetPageAsync(pageQuery);

            return _mapper.Map<PageReadModel<OrderHeaderReadModel>, BrowseOrdersResponse>(pageResult);
        }
    }
}