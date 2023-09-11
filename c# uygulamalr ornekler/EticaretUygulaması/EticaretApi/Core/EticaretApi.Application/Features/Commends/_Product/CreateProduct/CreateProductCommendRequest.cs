using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Commends._Product.CreateProduct
{
    public class CreateProductCommendRequest : IRequest<CreateProductCommendResponse>
    {
        //parametreler
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
    }
}
