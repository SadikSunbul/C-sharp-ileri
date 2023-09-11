using EticaretApi.Application.Repositories;
using EticaretApi.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Queries.ProductImageFile.GetProductImage
{
    public class GetProductImageQueryHeandler : IRequestHandler<GetProductImageQueryRequest, List<GetProductImageQueryResponse>>
    {
        public GetProductImageQueryHeandler(IProductReadRepository productReadRepository)
        {
            ProductReadRepository = productReadRepository;
        }

        public IProductReadRepository ProductReadRepository { get; }

        //bırden fazla dondurcegıkmız ıcın List ıcıne aldık 3 yerı bır altakını bır ustekını bırde request<> içindekini
        public async Task<List<GetProductImageQueryResponse>> Handle(GetProductImageQueryRequest request, CancellationToken cancellationToken)
        {

            Product? product = await ProductReadRepository.Table.Include(p => p.ProductImageFiles).FirstOrDefaultAsync(p => p.Id == Guid.Parse(request.Id));
            
            return  product?.ProductImageFiles.Select(p => new GetProductImageQueryResponse
            {
                Path = $"{p.Path}",
                FileName = p.FileName,
                Id = p.Id
            }).ToList();

        }
    }
}
