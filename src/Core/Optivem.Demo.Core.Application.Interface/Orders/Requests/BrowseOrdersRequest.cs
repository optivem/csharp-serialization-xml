using Optivem.Framework.Core.Application;
using Optivem.Demo.Core.Application.Orders.Responses;

namespace Optivem.Demo.Core.Application.Orders.Requests
{
    public class BrowseOrdersRequest : IRequest<BrowseOrdersResponse>
    {
        public int Page { get; set; }

        public int Size { get; set; }
    }
}