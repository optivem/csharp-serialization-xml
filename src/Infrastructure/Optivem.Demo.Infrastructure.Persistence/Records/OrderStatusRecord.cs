using Optivem.Framework.Infrastructure.EntityFrameworkCore;
using Optivem.Demo.Core.Common.Orders;
using System.Collections.Generic;

namespace Optivem.Demo.Infrastructure.Persistence.Records
{
    public class OrderStatusRecord : Record<OrderStatus>
    {
        public OrderStatusRecord()
        {
            OrderRecords = new HashSet<OrderRecord>();
        }

        public string Code { get; set; }

        public virtual ICollection<OrderRecord> OrderRecords { get; set; }
    }
}