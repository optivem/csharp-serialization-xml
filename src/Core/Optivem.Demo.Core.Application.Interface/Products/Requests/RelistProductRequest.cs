using Optivem.Framework.Core.Application;
using Optivem.Demo.Core.Application.Products.Responses;
using System;

namespace Optivem.Demo.Core.Application.Products.Requests
{
    public class RelistProductRequest : IRequest<RelistProductResponse>
    {
        public Guid Id { get; set; }
    }
}