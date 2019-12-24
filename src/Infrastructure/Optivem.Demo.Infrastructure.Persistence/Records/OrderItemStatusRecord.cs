using Optivem.Framework.Infrastructure.EntityFrameworkCore;
using Optivem.Demo.Core.Common.Orders;
using System.Collections.Generic;

namespace Optivem.Demo.Infrastructure.Persistence.Records
{
    public class OrderItemStatusRecord : Record<OrderItemStatus>
    {
        public OrderItemStatusRecord()
        {
            OrderItems = new HashSet<OrderItemRecord>();
        }

        public string Code { get; set; }

        public virtual ICollection<OrderItemRecord> OrderItems { get; set; }
    }
}