using EticaretApi.Application.Abstractions.Storage;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Commends.ProductImageFile.ProductImageUpload
{
    public class ProductImageUploadProductCommendRequest : IRequest<ProductImageUploadProductCommendResponse>
    {
        public string ProductId { get; set; }
        public IFormFileCollection? files { get; set; }
        
    }
}
