using EticaretApi.Application.Repositories;
using EticaretApi.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EticaretApi.Application.Features.Commends.ProductImageFile.RemoveProduct
{
    public class RemoveProductCommendHandler : IRequestHandler<RemoveProductCommendRequest, RemoveProductCommendResponse>
    {
        public RemoveProductCommendHandler(IProductReadRepository _productReadRepository, IProductWriteRepository _productWriteRepository)
        {
            ProductReadRepository = _productReadRepository;
            ProductWriteRepository = _productWriteRepository;
        }

        public IProductReadRepository ProductReadRepository { get; }
        public IProductWriteRepository ProductWriteRepository { get; }

        public async Task<RemoveProductCommendResponse> Handle(RemoveProductCommendRequest request, CancellationToken cancellationToken)
        {
            Product? product = await ProductReadRepository.Table.Include(p => p.ProductImageFiles).FirstOrDefaultAsync(p => p.Id == Guid.Parse(request.Id));
            var productImage = product?.ProductImageFiles.FirstOrDefault(p => p.Id == Guid.Parse(request.ImageId));
            if (productImage!=null)
            {
                product?.ProductImageFiles.Remove(productImage);
            }
            
            await ProductWriteRepository.SaveAsync();
            return new();
        }
    }
}
