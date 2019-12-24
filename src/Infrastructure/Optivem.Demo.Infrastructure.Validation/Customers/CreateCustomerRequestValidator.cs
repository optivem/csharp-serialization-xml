using FluentValidation;
using Optivem.Framework.Infrastructure.FluentValidation;
using Optivem.Demo.Core.Application.Customers.Requests;

namespace Optivem.Demo.Infrastructure.Validation.Customers
{
    public class CreateCustomerRequestValidator : BaseValidator<CreateCustomerRequest>
    {
        public CreateCustomerRequestValidator()
        {
            RuleFor(e => e.FirstName).NotNull();
            RuleFor(e => e.LastName).NotNull();
        }
    }
}