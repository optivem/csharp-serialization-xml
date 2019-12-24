using FluentValidation;
using Optivem.Framework.Infrastructure.FluentValidation;
using Optivem.Demo.Core.Application.Products.Requests;

namespace Optivem.Demo.Infrastructure.Validation.Products
{
    public class UpdateProductRequestValidator : BaseValidator<UpdateProductRequest>
    {
        public UpdateProductRequestValidator()
        {
            RuleFor(e => e.Description).NotNull();
            RuleFor(e => e.UnitPrice).GreaterThan(0);
        }
    }
}