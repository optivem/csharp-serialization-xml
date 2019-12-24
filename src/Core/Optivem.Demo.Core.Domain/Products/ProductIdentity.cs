using Optivem.Framework.Core.Domain;
using System;

namespace Optivem.Demo.Core.Domain.Products
{
    public class ProductIdentity : Identity<Guid>
    {
        public ProductIdentity(Guid value)
            : base(value)
        {
        }
    }
}