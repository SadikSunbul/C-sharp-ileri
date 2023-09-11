using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.ViewModel._Like
{
    public class VM_Like_List
    {
        public Guid YemekId { get; set; }
        public Guid LikeId { get; set; }
        
        public string İsim { get; set; }
        public double Fiyat { get; set; }
    }
}
