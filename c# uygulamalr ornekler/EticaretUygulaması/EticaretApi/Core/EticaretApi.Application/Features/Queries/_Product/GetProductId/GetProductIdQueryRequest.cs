using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Queries._Product.GetProductId
{
    public class GetProductIdQueryRequest:IRequest<GetProductIdQueryResponse>
    {
        public string ProductId { get; set;}
    }
}
