using EticaretApi.Application.Repositories;
using EticaretApi.Application.RequestParameters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Queries._Product.GetAllProduct
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, GetAllProducQueryResponse>
    {
        private readonly IProductReadRepository productReadRepository;

        public GetAllProductQueryHandler(IProductReadRepository _productReadRepository)
        {
            productReadRepository = _productReadRepository;
        }
        //IRequestHandler<GetAllProductQueryRequest, GetAllProducQueryResponse>  -->Requestı handler edıcek gerıye Response doncek demıs oluyoruz
        public async Task<GetAllProducQueryResponse> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {//ilgili işlemler burada gerceklestırıyoruz
            var totalcount = productReadRepository.GetAll(false).Count();
            var data = productReadRepository.GetAll(false)
            .Select(p => new
            {
                p.Id,//ıd yı sılme ıslemı yparsa dıye gonderıyorum 
                p.Name,
                p.Stock,
                p.Price,
                p.CreateDate,
                p.UpdateDate
            })
            .Skip(request.pagination.Page * request.pagination.Size)  //request nesnesındekı verıyı alma 
            .Take(request.pagination.Size)
            .ToList();
            return new()
            {
                Products = data,
                TotalCount = totalcount
            };

        }
    }
}
