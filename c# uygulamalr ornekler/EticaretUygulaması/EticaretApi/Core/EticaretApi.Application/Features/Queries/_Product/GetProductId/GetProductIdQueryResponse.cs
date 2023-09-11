using EticaretApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Queries._Product.GetProductId
{
    public class GetProductIdQueryResponse
    {
        public string Name { get; set; }

        public float Price { get; set; }
        public int Stock { get; set; }
    }
}
