using System.Threading.Tasks;

namespace Optivem.Demo.Core.Domain.Customers
{
    public interface ICustomerRepository : ICustomerReadRepository
    {
        void Add(Customer customer);

        Task UpdateAsync(Customer customer);

        void Remove(CustomerIdentity customerId);
    }
}