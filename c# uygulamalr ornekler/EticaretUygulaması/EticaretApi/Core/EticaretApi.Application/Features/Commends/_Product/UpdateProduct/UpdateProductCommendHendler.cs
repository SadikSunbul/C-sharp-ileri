using EticaretApi.Application.Repositories;
using EticaretApi.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Commends._Product.UpdateProduct
{
    public class UpdateProductCommendHendler : IRequestHandler<UpdateProductCommendRequest, UpdateProductCommendResponse>
    {
        public UpdateProductCommendHendler(IProductReadRepository productReadRepository ,IProductImageWriteRepository productImageWriteRepository)
        {
            ProductReadRepository = productReadRepository;
            ProductImageWriteRepository = productImageWriteRepository;
        }

        public IProductReadRepository ProductReadRepository { get; }
        public IProductImageWriteRepository ProductImageWriteRepository { get; }

        public async Task<UpdateProductCommendResponse> Handle(UpdateProductCommendRequest request, CancellationToken cancellationToken)
        {
            Product product = await ProductReadRepository.GetByIdAsync(request.Id); // Id verıp tum nesneyı elde ettık 
            product.Stock = request.Stock;
            product.Price = request.Price;
            product.Name = request.Name;

            await ProductImageWriteRepository.SaveAsync();
            return new UpdateProductCommendResponse() { Update = true };
        }
    }
}
