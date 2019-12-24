using AutoMapper;
using Optivem.Demo.Core.Application.Customers.Responses;
using Optivem.Demo.Core.Domain.Customers;

namespace Optivem.Demo.Infrastructure.Mapping.Customers
{
    public class UpdateCustomerResponseProfile : Profile
    {
        public UpdateCustomerResponseProfile()
        {
            CreateMap<Customer, UpdateCustomerResponse>();
        }
    }
}