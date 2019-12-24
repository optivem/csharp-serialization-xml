using System.Threading.Tasks;
using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Application.Mapping;
using Optivem.Framework.Core.Domain;
using Optivem.Demo.Core.Application.Customers.Requests;
using Optivem.Demo.Core.Application.Customers.Responses;
using Optivem.Demo.Core.Domain.Customers;

namespace Optivem.Demo.Core.Application.Customers.UseCases
{
    public class BrowseCustomersUseCase : IRequestHandler<BrowseCustomersRequest, BrowseCustomersResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerReadRepository _customerReadRepository;

        public BrowseCustomersUseCase(IMapper mapper, ICustomerReadRepository customerReadRepository)
        {
            _mapper = mapper;
            _customerReadRepository = customerReadRepository;
        }

        public async Task<BrowseCustomersResponse> HandleAsync(BrowseCustomersRequest request)
        {
            var pageQuery = new PageQuery(request.Page, request.Size);
            var pageResult = await _customerReadRepository.GetPageAsync(pageQuery);

            return _mapper.Map<PageReadModel<CustomerHeaderReadModel>, BrowseCustomersResponse>(pageResult);
        }
    }
}