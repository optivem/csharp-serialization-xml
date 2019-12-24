using Optivem.Framework.Core.Domain;
using System;

namespace Optivem.Demo.Core.Domain.Orders
{
    public class OrderItemIdentity : Identity<Guid>
    {
        public OrderItemIdentity(Guid value)
            : base(value)
        {
        }
    }
}