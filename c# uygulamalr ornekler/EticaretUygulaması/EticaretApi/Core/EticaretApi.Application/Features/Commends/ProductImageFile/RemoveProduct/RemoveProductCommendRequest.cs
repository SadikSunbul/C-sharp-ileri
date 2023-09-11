using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Commends.ProductImageFile.RemoveProduct
{
    public class RemoveProductCommendRequest:IRequest<RemoveProductCommendResponse>
    {
        public string Id { get; set; }
        public string? ImageId { get; set; }
    }
}
