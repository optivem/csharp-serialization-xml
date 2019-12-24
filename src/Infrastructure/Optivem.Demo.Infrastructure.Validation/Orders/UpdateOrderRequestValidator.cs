using FluentValidation;
using Optivem.Framework.Infrastructure.FluentValidation;
using Optivem.Demo.Core.Application.Orders.Requests;

namespace Optivem.Demo.Infrastructure.Validation.Orders
{
    public class UpdateOrderRequestValidator : BaseValidator<UpdateOrderRequest>
    {
        public UpdateOrderRequestValidator()
        {
            RuleFor(e => e.OrderItems).NotNull();
        }
    }
}