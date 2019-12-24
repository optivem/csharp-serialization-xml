using FluentValidation;
using Optivem.Framework.Infrastructure.FluentValidation;
using Optivem.Demo.Core.Application.Orders.Requests;

namespace Optivem.Demo.Infrastructure.Validation.Orders
{
    public class CreateOrderRequestValidator : BaseValidator<CreateOrderRequest>
    {
        public CreateOrderRequestValidator()
        {
            RuleFor(e => e.CustomerId).NotEmpty();
            RuleFor(e => e.OrderItems).NotNull();
        }
    }
}