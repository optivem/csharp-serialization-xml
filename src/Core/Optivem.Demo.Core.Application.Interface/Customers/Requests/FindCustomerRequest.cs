using Optivem.Framework.Core.Application;
using Optivem.Demo.Core.Application.Customers.Responses;
using System;

namespace Optivem.Demo.Core.Application.Customers.Requests
{
    public class FindCustomerRequest : IRequest<FindCustomerResponse>
    {
        public Guid Id { get; set; }
    }
}