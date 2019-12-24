﻿using Optivem.Framework.Core.Domain;
using Optivem.Demo.Core.Common.Orders;
using Optivem.Demo.Core.Domain.Customers;
using Optivem.Demo.Core.Domain.Products;
using System;
using System.Collections.Generic;

namespace Optivem.Demo.Core.Domain.Orders
{
    public class OrderFactory : IOrderFactory
    {
        private readonly IIdentityGenerator<OrderIdentity> _orderIdentityGenerator;
        private readonly IIdentityGenerator<OrderItemIdentity> _orderItemIdentityGenerator;
        private readonly ITimeService _timeService;

        public OrderFactory(IIdentityGenerator<OrderIdentity> orderIdentityGenerator, 
            IIdentityGenerator<OrderItemIdentity> orderItemIdentityGenerator,
            ITimeService timeService)
        {
            _orderIdentityGenerator = orderIdentityGenerator;
            _orderItemIdentityGenerator = orderItemIdentityGenerator;
            _timeService = timeService;
        }

        public Order CreateNewOrder(CustomerIdentity customerId, IEnumerable<OrderItem> orderDetails)
        {
            var id = _orderIdentityGenerator.Next();
            var orderDate = _timeService.Now;
            return new Order(id, customerId, orderDate, OrderStatus.New, orderDetails);
        }

        public OrderItem CreateNewOrderItem(Product product, decimal quantity)
        {
            if (product == null)
            {
                throw new ArgumentException();
            }

            if (quantity < 0)
            {
                throw new ArgumentException();
            }

            var id = _orderItemIdentityGenerator.Next();

            return new OrderItem(id, product.Id, quantity, product.ListPrice, OrderItemStatus.Allocated);
        }
    }
}