using Optivem.Framework.Core.Domain;
using Optivem.Demo.Core.Domain.Customers;
using Optivem.Demo.Core.Domain.Products;
using System.Collections.Generic;

namespace Optivem.Demo.Core.Domain.Orders
{
    public interface IOrderFactory : IFactory
    {
        Order CreateNewOrder(CustomerIdentity customerId, IEnumerable<OrderItem> orderDetails);

        OrderItem CreateNewOrderItem(Product product, decimal quantity);
    }
}
