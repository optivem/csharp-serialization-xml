using FluentValidation;
using Optivem.Framework.Infrastructure.FluentValidation;
using Optivem.Demo.Core.Application.Customers.Requests;

namespace Optivem.Demo.Infrastructure.Validation.Customers
{
    public class UpdateCustomerRequestValidator : BaseValidator<UpdateCustomerRequest>
    {
        public UpdateCustomerRequestValidator()
        {
            RuleFor(e => e.FirstName).NotNull();
            RuleFor(e => e.LastName).NotNull();
        }
    }
}