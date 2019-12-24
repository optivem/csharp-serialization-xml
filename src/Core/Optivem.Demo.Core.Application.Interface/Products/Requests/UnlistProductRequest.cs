using Optivem.Framework.Core.Application;
using Optivem.Demo.Core.Application.Products.Responses;
using System;

namespace Optivem.Demo.Core.Application.Products.Requests
{
    public class UnlistProductRequest : IRequest<UnlistProductResponse>
    {
        public Guid Id { get; set; }
    }
}