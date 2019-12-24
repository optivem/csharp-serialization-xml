using Optivem.Framework.Core.Application;
using Optivem.Demo.Core.Application.Products.Responses;

namespace Optivem.Demo.Core.Application.Products.Requests
{
    public class CreateProductRequest : IRequest<CreateProductResponse>
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }
    }
}