using Optivem.Framework.Core.Domain;
using System;

namespace Optivem.Demo.Core.Domain.Customers
{
    public class CustomerIdentityGenerator : IIdentityGenerator<CustomerIdentity>
    {
        public CustomerIdentity Next()
        {
            return new CustomerIdentity(Guid.NewGuid());
        }
    }
}
