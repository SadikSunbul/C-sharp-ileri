using EticaretApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
