using System;
using System.Collections.Generic;

namespace Optivem.Demo.Core.Application.Products.Responses
{
    public class ListProductsResponse
    {
        public List<ListProductsRecordResponse> Records { get; set; }

        public int TotalRecords { get; set; }
    }

    public class ListProductsRecordResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}