using EticaretApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public string Description { get; set; } //acıkalam
        public string Address { get; set; }

        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }
    }
}
