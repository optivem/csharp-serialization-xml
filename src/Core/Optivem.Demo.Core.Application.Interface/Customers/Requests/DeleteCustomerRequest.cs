﻿using Optivem.Framework.Core.Application;
using Optivem.Demo.Core.Application.Customers.Responses;
using System;

namespace Optivem.Demo.Core.Application.Customers.Requests
{
    public class DeleteCustomerRequest : IRequest<DeleteCustomerResponse>
    {
        public Guid Id { get; set; }
    }
}