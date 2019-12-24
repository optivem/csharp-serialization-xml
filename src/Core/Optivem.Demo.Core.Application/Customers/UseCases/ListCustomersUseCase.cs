﻿using System.Threading.Tasks;
using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Application.Mapping;
using Optivem.Framework.Core.Domain;
using Optivem.Demo.Core.Application.Customers.Requests;
using Optivem.Demo.Core.Application.Customers.Responses;
using Optivem.Demo.Core.Domain.Customers;

namespace Optivem.Demo.Core.Application.Customers.UseCases
{
    public class ListCustomersUseCase : IRequestHandler<ListCustomersRequest, ListCustomersResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerReadRepository _customerReadRepository;

        public ListCustomersUseCase(IMapper mapper, ICustomerReadRepository customerReadRepository)
        {
            _mapper = mapper;
            _customerReadRepository = customerReadRepository;
        }

        public async Task<ListCustomersResponse> HandleAsync(ListCustomersRequest request)
        {
            var listResult = await _customerReadRepository.ListAsync(request.NameSearch, request.Limit);

            return _mapper.Map<ListReadModel<CustomerIdNameReadModel>, ListCustomersResponse>(listResult);
        }
    }
}