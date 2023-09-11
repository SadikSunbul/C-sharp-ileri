using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Queries.ProductImageFile.GetProductImage
{
    public class GetProductImageQueryResponse
    {
        public string Path { get; set; }
        public string FileName { get; set; }
        public Guid Id { get; set; }
    }
}
