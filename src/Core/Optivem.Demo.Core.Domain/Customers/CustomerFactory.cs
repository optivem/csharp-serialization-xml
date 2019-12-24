﻿using Optivem.Framework.Core.Domain;

namespace Optivem.Demo.Core.Domain.Customers
{
    public class CustomerFactory : ICustomerFactory
    {
        private readonly IIdentityGenerator<CustomerIdentity> _customerIdentityGenerator;

        public CustomerFactory(IIdentityGenerator<CustomerIdentity> customerIdentityGenerator)
        {
            _customerIdentityGenerator = customerIdentityGenerator;
        }

        public Customer Create(string firstName, string lastName)
        {
            var id = _customerIdentityGenerator.Next();

            return new Customer(id, firstName, lastName);
        }
    }
}
