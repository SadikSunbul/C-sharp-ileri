using Restorant.Domain.Entiteis.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Domain.Entiteis
{
    public class Basket:BaseEntity
    {
        public int Adet { get; set; }
        public Guid CustomerId { get; set; }
        public Guid FoodId { get; set; }
        public Customer Customer { get; set; }
        public Food Food{ get; set; }
        
    }
}
