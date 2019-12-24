using System.Threading.Tasks;
using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Application.Mapping;
using Optivem.Demo.Core.Application.Customers.Requests;
using Optivem.Demo.Core.Application.Customers.Responses;
using Optivem.Demo.Core.Domain.Customers;

namespace Optivem.Demo.Core.Application.Customers.UseCases
{
    public class FindCustomerUseCase : IRequestHandler<FindCustomerRequest, FindCustomerResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerReadRepository _customerReadRepository;

        public FindCustomerUseCase(IMapper mapper, ICustomerReadRepository customerReadRepository)
        {
            _mapper = mapper;
            _customerReadRepository = customerReadRepository;
        }

        public async Task<FindCustomerResponse> HandleAsync(FindCustomerRequest request)
        {
            var customerId = new CustomerIdentity(request.Id);

            var customerDetail = await _customerReadRepository.GetDetailAsync(customerId);

            if (customerDetail == null)
            {
                throw new NotFoundRequestException();
            }

            return _mapper.Map<CustomerDetailReadModel, FindCustomerResponse>(customerDetail);
        }
    }
}