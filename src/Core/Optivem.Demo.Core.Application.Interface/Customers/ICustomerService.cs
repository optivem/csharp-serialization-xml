using Optivem.Framework.Core.Application;
using Optivem.Demo.Core.Application.Customers.Requests;
using Optivem.Demo.Core.Application.Customers.Responses;
using System.Threading.Tasks;

namespace Optivem.Demo.Core.Application.Customers
{
    public interface ICustomerService : IApplicationService
    {
        Task<BrowseCustomersResponse> BrowseCustomersAsync(BrowseCustomersRequest request);

        Task<CreateCustomerResponse> CreateCustomerAsync(CreateCustomerRequest request);

        Task<DeleteCustomerResponse> DeleteCustomerAsync(DeleteCustomerRequest request);

        Task<FindCustomerResponse> FindCustomerAsync(FindCustomerRequest request);

        Task<ListCustomersResponse> ListCustomersAsync(ListCustomersRequest request);

        Task<UpdateCustomerResponse> UpdateCustomerAsync(UpdateCustomerRequest request);
    }
}