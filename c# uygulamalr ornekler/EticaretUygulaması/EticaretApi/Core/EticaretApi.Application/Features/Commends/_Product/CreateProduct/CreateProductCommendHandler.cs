using EticaretApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Commends._Product.CreateProduct
{
    public class CreateProductCommendHandler : IRequestHandler<CreateProductCommendRequest, CreateProductCommendResponse>
    {
        private readonly IProductWriteRepository productWriteRepository;

        public CreateProductCommendHandler(IProductWriteRepository productWriteRepository)
        {
            this.productWriteRepository = productWriteRepository;
        }
        public async Task<CreateProductCommendResponse> Handle(CreateProductCommendRequest request, CancellationToken cancellationToken)
        {

            await productWriteRepository.AddAsync(new Domain.Entities.Product()
            {
                Name = request.Name,
                Price = request.Price,
                Stock = request.Stock
            }); //ekledik 
            await productWriteRepository.SaveAsync(); //Kaydettik

            return new();//bisey dondurmedık burada 
        }
    }
}
