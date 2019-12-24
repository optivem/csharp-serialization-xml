using Optivem.Framework.Core.Application;
using Optivem.Demo.Core.Application.Products.Responses;
using System;

namespace Optivem.Demo.Core.Application.Products.Requests
{
    public class FindProductRequest : IRequest<FindProductResponse>
    {
        public Guid Id { get; set; }
    }
}