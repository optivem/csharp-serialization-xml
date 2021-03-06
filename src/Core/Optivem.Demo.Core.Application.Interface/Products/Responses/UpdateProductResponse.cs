﻿using System;

namespace Optivem.Demo.Core.Application.Products.Responses
{
    public class UpdateProductResponse
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }

        public bool IsListed { get; set; }
    }
}