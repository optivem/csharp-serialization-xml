using Optivem.Framework.Core.Application;
using Optivem.Demo.Core.Application.Customers.Responses;

namespace Optivem.Demo.Core.Application.Customers.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}