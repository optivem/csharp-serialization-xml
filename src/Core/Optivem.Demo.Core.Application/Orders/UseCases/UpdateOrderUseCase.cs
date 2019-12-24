﻿using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Application.Mapping;
using Optivem.Framework.Core.Domain;
using Optivem.Demo.Core.Application.Orders.Requests;
using Optivem.Demo.Core.Application.Orders.Responses;
using Optivem.Demo.Core.Domain.Orders;
using Optivem.Demo.Core.Domain.Products;
using System.Linq;
using System.Threading.Tasks;

namespace Optivem.Demo.Core.Application.Orders.UseCases
{
    public class UpdateOrderUseCase : IRequestHandler<UpdateOrderRequest, UpdateOrderResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderRepository _orderRepository;
        private readonly IProductReadRepository _productReadRepository;
        private readonly IOrderFactory _orderFactory;

        public UpdateOrderUseCase(IMapper mapper, 
            IUnitOfWork unitOfWork, 
            IOrderRepository orderRepository, 
            IProductReadRepository productReadRepository,
            IOrderFactory orderFactory)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _orderRepository = orderRepository;
            _productReadRepository = productReadRepository;
            _orderFactory = orderFactory;
        }

        public async Task<UpdateOrderResponse> HandleAsync(UpdateOrderRequest request)
        {
            var orderId = new OrderIdentity(request.Id);

            var order = await _orderRepository.FindAsync(orderId);

            if (order == null)
            {
                throw new NotFoundRequestException();
            }

            await UpdateAsync(order, request);

            await _orderRepository.UpdateAsync(order);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<Order, UpdateOrderResponse>(order);
        }

        private async Task UpdateAsync(Order order, UpdateOrderRequest request)
        {
            var currentOrderDetails = order.OrderItems;

            var addedOrderRequestDetails = request.OrderItems.Where(e => e.Id == null).ToList();
            var updatedOrderRequestDetails = request.OrderItems.Where(e => e.Id != null).ToList();
            var deletedOrderDetails = order.OrderItems.Where(e => !request.OrderItems.Any(f => f.Id == e.Id.Value)).ToList();

            foreach (var added in addedOrderRequestDetails)
            {
                var productId = new ProductIdentity(added.ProductId);
                var product = await _productReadRepository.FindAsync(productId);

                if (product == null)
                {
                    throw new InvalidRequestException($"Product {productId} does not exist");
                }

                var orderDetail = _orderFactory.CreateNewOrderItem(product, added.Quantity);
                order.AddOrderItem(orderDetail);
            }

            foreach (var updated in updatedOrderRequestDetails)
            {
                var orderDetailId = new OrderItemIdentity(updated.Id.Value);
                var orderDetail = order.OrderItems.First(e => e.Id == orderDetailId);

                var productId = new ProductIdentity(updated.ProductId);
                var product = await _productReadRepository.FindAsync(productId);

                if (product == null)
                {
                    throw new InvalidRequestException($"Product {productId} does not exist");
                }

                orderDetail.SetProduct(product);
                orderDetail.Quantity = updated.Quantity;
            }

            foreach (var deleted in deletedOrderDetails)
            {
                order.RemoveOrderItem(deleted.Id);
            }
        }
    }
}