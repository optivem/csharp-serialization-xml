using Optivem.Framework.Core.Application;
using Optivem.Demo.Core.Application.Orders.Responses;
using System;

namespace Optivem.Demo.Core.Application.Orders.Requests
{
    public class ArchiveOrderRequest : IRequest<ArchiveOrderResponse>
    {
        public Guid Id { get; set; }
    }
}