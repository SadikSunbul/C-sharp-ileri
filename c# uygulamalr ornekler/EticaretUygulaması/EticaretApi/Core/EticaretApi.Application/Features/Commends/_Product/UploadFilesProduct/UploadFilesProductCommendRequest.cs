using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Commends._Product.UploadFilesProduct
{
    public class UploadFilesProductCommendRequest:IRequest<UploadFilesProductCommendResponse>
    {
        public List<IFormFile> Files { get; set; }
    }
}
