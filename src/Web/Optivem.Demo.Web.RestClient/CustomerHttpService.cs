﻿using Optivem.Framework.Core.Common.Http;
using Optivem.Framework.Infrastructure.AspNetCore;
using Optivem.Demo.Core.Application.Customers.Requests;
using Optivem.Demo.Core.Application.Customers.Responses;
using Optivem.Demo.Web.RestClient.Interface;
using System;
using System.Threading.Tasks;

namespace Optivem.Demo.Web.RestClient
{
    public class CustomerHttpService : BaseControllerClient, ICustomerHttpService
    {
        public CustomerHttpService(IControllerClientFactory clientFactory)
            : base(clientFactory, "api/customers")
        {
        }

        public Task<IObjectClientResponse<BrowseCustomersResponse>> BrowseCustomersAsync(BrowseCustomersRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IObjectClientResponse<CreateCustomerResponse>> CreateCustomerAsync(CreateCustomerRequest request)
        {
            return Client.PostAsync<CreateCustomerRequest, CreateCustomerResponse>(request);
        }

        public Task<IObjectClientResponse<DeleteCustomerResponse>> DeleteCustomerAsync(DeleteCustomerRequest request)
        {
            var id = request.Id;
            return Client.DeleteByIdAsync<Guid, DeleteCustomerResponse>(id);
        }

        public Task<IObjectClientResponse<FindCustomerResponse>> FindCustomerAsync(FindCustomerRequest request)
        {
            var id = request.Id;
            return Client.GetByIdAsync<Guid, FindCustomerResponse>(id);
        }

        public Task<IObjectClientResponse<ListCustomersResponse>> ListCustomersAsync(ListCustomersRequest request)
        {
            return Client.GetAsync<ListCustomersResponse>();
        }

        public Task<IObjectClientResponse<UpdateCustomerResponse>> UpdateCustomerAsync(UpdateCustomerRequest request)
        {
            return Client.PutByIdAsync<Guid, UpdateCustomerRequest, UpdateCustomerResponse>(request.Id, request);
        }
    }
}