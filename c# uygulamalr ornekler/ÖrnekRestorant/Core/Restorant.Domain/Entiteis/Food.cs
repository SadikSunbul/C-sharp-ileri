using Restorant.Domain.Entiteis.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Domain.Entiteis
{
    public class Food:BaseEntity
    {
        public Food()
        {
            Orders = new HashSet<Order>();
            Baskets=new HashSet<Basket>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Exists { get; set; }
        
        public ICollection<Order> Orders { get; set; }
        public ICollection<Basket> Baskets { get; set; }
        public ICollection<Like> Customers{ get; set; }
        public ICollection<Payment> Payments{ get; set; }
        //todo resim eklenicek 
    }
}
