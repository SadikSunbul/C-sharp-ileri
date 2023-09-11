using EticaretApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Commends._Product.DeleteProduct
{
    public class DeletProductCommendHandler : IRequestHandler<DeletProductCommendRequest, DeletProductCommendResponse>
    {
        private readonly IProductWriteRepository productWriteRepository;

        public DeletProductCommendHandler(IProductWriteRepository productWriteRepository)
        {
            this.productWriteRepository = productWriteRepository;
        }
        public async Task<DeletProductCommendResponse> Handle(DeletProductCommendRequest request, CancellationToken cancellationToken)
        {
            var data = await productWriteRepository.RemoveAsync(request.Id);
            if (data)
            {
                await productWriteRepository.SaveAsync();
                return new() { Delete=true };
            }
            else
            {
                return new() { Delete = false };
            }

        }
    }
}
