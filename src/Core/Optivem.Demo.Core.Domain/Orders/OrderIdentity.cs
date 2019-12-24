using Optivem.Framework.Core.Domain;
using System;

namespace Optivem.Demo.Core.Domain.Orders
{
    public class OrderIdentity : Identity<Guid>
    {
        public OrderIdentity(Guid value) : base(value)
        {
        }
    }
}