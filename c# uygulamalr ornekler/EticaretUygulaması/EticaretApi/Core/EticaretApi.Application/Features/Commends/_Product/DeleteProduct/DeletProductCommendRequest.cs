using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Commends._Product.DeleteProduct
{
    public class DeletProductCommendRequest : IRequest<DeletProductCommendResponse>
    {
        public string Id { get; set; }
    }
}
