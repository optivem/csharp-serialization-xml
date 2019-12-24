using Optivem.Framework.Core.Domain;
using System;

namespace Optivem.Demo.Core.Domain.Orders
{
    public class OrderIdentityGenerator : IIdentityGenerator<OrderIdentity>
    {
        public OrderIdentity Next()
        {
            return new OrderIdentity(Guid.NewGuid());
        }
    }
}
