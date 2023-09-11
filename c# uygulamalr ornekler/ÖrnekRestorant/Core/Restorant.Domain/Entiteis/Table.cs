using Restorant.Domain.Entiteis.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Domain.Entiteis
{
    public class Table:BaseEntity
    {
        public Table()
        {
            Orders=new HashSet<Order>();
        }
        public string TableNo { get; set; }
        public int Maxpeople { get; set; } = 4;
        public bool Reservation { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
