using System;
using System.Collections.Generic;

namespace Optivem.Demo.Core.Application.Orders.Responses
{
    public class ListOrdersResponse
    {
        public List<ListOrdersRecordResponse> Records { get; set; }

        public int TotalRecords { get; set; }
    }

    public class ListOrdersRecordResponse
    {
        public Guid Id { get; set; }
    }
}