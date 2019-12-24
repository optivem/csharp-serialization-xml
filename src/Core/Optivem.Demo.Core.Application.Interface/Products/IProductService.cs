using Optivem.Framework.Core.Application;
using Optivem.Demo.Core.Application.Products.Requests;
using Optivem.Demo.Core.Application.Products.Responses;
using System.Threading.Tasks;

namespace Optivem.Demo.Core.Application.Products
{
    public interface IProductService : IApplicationService
    {
        Task<BrowseProductsResponse> BrowseProductsAsync(BrowseProductsRequest request);

        Task<CreateProductResponse> CreateProductAsync(CreateProductRequest request);

        Task<FindProductResponse> FindProductAsync(FindProductRequest request);

        Task<ListProductsResponse> ListProductsAsync(ListProductRequest request);

        Task<RelistProductResponse> RelistProductAsync(RelistProductRequest request);

        Task<UnlistProductResponse> UnlistProductAsync(UnlistProductRequest request);

        Task<UpdateProductResponse> UpdateProductAsync(UpdateProductRequest request);
    }
}