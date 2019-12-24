﻿using System.Threading.Tasks;
using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Application.Mapping;
using Optivem.Framework.Core.Domain;
using Optivem.Demo.Core.Application.Products.Requests;
using Optivem.Demo.Core.Application.Products.Responses;
using Optivem.Demo.Core.Domain.Products;

namespace Optivem.Demo.Core.Application.Products.UseCases
{
    public class ListProductsUseCase : IRequestHandler<ListProductRequest, ListProductsResponse>
    {
        private readonly IMapper _mapper;
        private readonly IProductReadRepository _productReadRepository;

        public ListProductsUseCase(IMapper mapper, IProductReadRepository productReadRepository)
        {
            _mapper = mapper;
            _productReadRepository = productReadRepository;
        }

        public async Task<ListProductsResponse> HandleAsync(ListProductRequest request)
        {
            var listResult = await _productReadRepository.ListAsync();

            return _mapper.Map<ListReadModel<ProductIdNameReadModel>, ListProductsResponse>(listResult);
        }
    }
}