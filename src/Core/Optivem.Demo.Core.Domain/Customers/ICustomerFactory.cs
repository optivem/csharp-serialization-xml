using Optivem.Framework.Core.Domain;

namespace Optivem.Demo.Core.Domain.Customers
{
    public interface ICustomerFactory : IFactory
    {
        Customer Create(string firstName, string lastName);
    }
}
