using Optivem.Framework.Core.Domain;
using System;

namespace Optivem.Demo.Core.Domain.Customers
{
    public class CustomerIdentity : Identity<Guid>
    {
        public CustomerIdentity(Guid value) : base(value)
        {
        }
    }
}