using Optivem.Framework.Core.Application;
using Optivem.Demo.Core.Application.Products.Responses;

namespace Optivem.Demo.Core.Application.Products.Requests
{
    public class BrowseProductsRequest : IRequest<BrowseProductsResponse>
    {
        public int Page { get; set; }

        public int Size { get; set; }
    }
}