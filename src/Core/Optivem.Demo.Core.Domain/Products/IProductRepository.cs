using System.Threading.Tasks;

namespace Optivem.Demo.Core.Domain.Products
{
    public interface IProductRepository : IProductReadRepository
    {
        void Add(Product product);

        Task UpdateAsync(Product product);
    }
}