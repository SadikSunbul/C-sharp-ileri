using Restorant.Domain.Entiteis.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Domain.Entiteis
{
    public class Order:BaseEntity
    {
        public Order()
        {
            Foods=new HashSet<Food>();
        }
        public bool ActiveOrder { get; set; }
        public Guid TableId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Food> Foods { get; set; }
        public Table Table { get; set; }
        

    }
}
