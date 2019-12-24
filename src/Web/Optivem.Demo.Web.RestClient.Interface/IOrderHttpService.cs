using Optivem.Framework.Core.Common.Http;
using Optivem.Demo.Core.Application.Orders.Requests;
using Optivem.Demo.Core.Application.Orders.Responses;
using System.Threading.Tasks;

namespace Optivem.Demo.Web.RestClient.Interface
{
    public interface IOrderHttpService : IHttpService
    {
        Task<IObjectClientResponse<ArchiveOrderResponse>> ArchiveOrderAsync(ArchiveOrderRequest request);

        Task<IObjectClientResponse<BrowseOrdersResponse>> BrowseOrdersAsync(BrowseOrdersRequest request);

        Task<IObjectClientResponse<CancelOrderResponse>> CancelOrderAsync(CancelOrderRequest request);

        Task<IObjectClientResponse<CreateOrderResponse>> CreateOrderAsync(CreateOrderRequest request);

        Task<IObjectClientResponse<FindOrderResponse>> FindOrderAsync(FindOrderRequest request);

        Task<IObjectClientResponse<ListOrdersResponse>> ListOrdersAsync(ListOrdersRequest request);

        Task<IObjectClientResponse<SubmitOrderResponse>> SubmitOrderAsync(SubmitOrderRequest request);

        Task<IObjectClientResponse<UpdateOrderResponse>> UpdateOrderAsync(UpdateOrderRequest request);
    }
}
