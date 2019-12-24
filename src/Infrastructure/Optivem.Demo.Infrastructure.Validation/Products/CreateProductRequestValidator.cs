using FluentValidation;
using Optivem.Framework.Infrastructure.FluentValidation;
using Optivem.Demo.Core.Application.Products.Requests;

namespace Optivem.Demo.Infrastructure.Validation.Products
{
    public class CreateProductRequestValidator : BaseValidator<CreateProductRequest>
    {
        public CreateProductRequestValidator()
        {
            RuleFor(e => e.Code).NotNull();
            RuleFor(e => e.Description).NotNull();
            RuleFor(e => e.UnitPrice).GreaterThan(0);
        }
    }
}