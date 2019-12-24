﻿using Optivem.Framework.Core.Application;
using Optivem.Demo.Core.Application.Orders.Responses;
using System;
using System.Collections.Generic;

namespace Optivem.Demo.Core.Application.Orders.Requests
{
    public class UpdateOrderRequest : IRequest<UpdateOrderResponse>
    {
        public Guid Id { get; set; }

        public List<UpdateOrderItemRequest> OrderItems { get; set; }
    }

    public class UpdateOrderItemRequest
    {
        public Guid? Id { get; set; }

        public Guid ProductId { get; set; }

        public decimal Quantity { get; set; }
    }
}