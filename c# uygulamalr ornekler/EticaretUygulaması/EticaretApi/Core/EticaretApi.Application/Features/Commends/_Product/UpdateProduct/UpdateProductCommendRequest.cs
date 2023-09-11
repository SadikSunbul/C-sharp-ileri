using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Commends._Product.UpdateProduct
{
    public class UpdateProductCommendRequest:IRequest<UpdateProductCommendResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
    }
}
