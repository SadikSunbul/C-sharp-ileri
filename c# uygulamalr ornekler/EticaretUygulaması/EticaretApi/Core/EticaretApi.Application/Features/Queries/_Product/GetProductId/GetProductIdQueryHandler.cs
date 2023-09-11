using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediatR;
using System.Threading.Tasks;
using EticaretApi.Application.Repositories;

namespace EticaretApi.Application.Features.Queries._Product.GetProductId
{
    public class GetProductIdQueryHandler : IRequestHandler<GetProductIdQueryRequest, GetProductIdQueryResponse>
    {
        public GetProductIdQueryHandler(IProductReadRepository productReadRepository)
        {
            ProductReadRepository = productReadRepository;
        }

        public IProductReadRepository ProductReadRepository { get; }

        public async Task<GetProductIdQueryResponse> Handle(GetProductIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await ProductReadRepository.GetByIdAsync(request.ProductId, false);
            if (data != null)
            {
                return new GetProductIdQueryResponse
                {
                    Name = data.Name,
                    Price = data.Price,
                    Stock = data.Stock
                };
            }
            return new();
        }
    }
}
