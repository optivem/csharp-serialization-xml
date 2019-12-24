﻿using Optivem.Framework.Core.Domain;
using System;

namespace Optivem.Demo.Core.Domain.Products
{
    public class ProductIdentityGenerator : IIdentityGenerator<ProductIdentity>
    {
        public ProductIdentity Next()
        {
            return new ProductIdentity(Guid.NewGuid());
        }
    }
}
