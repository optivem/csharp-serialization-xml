using Optivem.Framework.Core.Application;
using Optivem.Demo.Core.Application.Customers.Responses;
using System;

namespace Optivem.Demo.Core.Application.Customers.Requests
{
    public class UpdateCustomerRequest : IRequest<UpdateCustomerResponse>
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}