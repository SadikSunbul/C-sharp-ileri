using Restorant.Domain.Entiteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.ViewModel._Order
{
    public  class VM_Order_List
    {
        public VM_Order_List()
        {
            FoodName = new List<string>();
        }
        public bool ActiveOrder { get; set; }
        public string Masano { get; set; }
        public string İsim { get; set; }
        public string Soyisim { get; set; }
        public List<string> FoodName{ get; set; }
    }
}
