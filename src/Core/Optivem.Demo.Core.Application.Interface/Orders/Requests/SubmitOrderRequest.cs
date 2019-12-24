using Optivem.Framework.Core.Application;
using Optivem.Demo.Core.Application.Orders.Responses;
using System;

namespace Optivem.Demo.Core.Application.Orders.Requests
{
    public class SubmitOrderRequest : IRequest<SubmitOrderResponse>
    {
        public Guid Id { get; set; }
    }
}