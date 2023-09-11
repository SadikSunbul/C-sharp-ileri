using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Queries.ProductImageFile.GetProductImage
{
    public class GetProductImageQueryRequest:IRequest<List<GetProductImageQueryResponse>>
    {
        public string Id { get; set; }
      
    }
}
