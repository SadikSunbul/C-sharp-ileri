using EticaretApi.Application.RequestParameters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Queries._Product.GetAllProduct
{
    public class GetAllProductQueryRequest : IRequest<GetAllProducQueryResponse>
    {
        //IRequest<GetAllProducQueryResponse> gelen ıstegın karsılıgını burada belırlıyoruz sonra handle ye cecıcez
        public Pagination pagination { get; set; } //aldıgı parametre 
        //public int Page { get; set; } = 0;
        //public int Size { get; set; } = 5;
    }
}
