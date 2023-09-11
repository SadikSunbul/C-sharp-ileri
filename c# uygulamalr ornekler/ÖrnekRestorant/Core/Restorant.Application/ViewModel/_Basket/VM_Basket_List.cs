using Restorant.Domain.Entiteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.ViewModel._Basket
{
    public class VM_Basket_List
    {
        public Guid BasketId{ get; set; }
        public string YemekAdı { get; set; }
        public int Adet { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }


        
    }
}
