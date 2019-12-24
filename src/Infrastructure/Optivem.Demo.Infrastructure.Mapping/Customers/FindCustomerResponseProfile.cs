using AutoMapper;
using Optivem.Demo.Core.Application.Customers.Responses;
using Optivem.Demo.Core.Domain.Customers;

namespace Optivem.Demo.Infrastructure.Mapping.Customers
{
    public class FindCustomerResponseProfile : Profile
    {
        public FindCustomerResponseProfile()
        {
            CreateMap<CustomerDetailReadModel, FindCustomerResponse>();
        }
    }
}