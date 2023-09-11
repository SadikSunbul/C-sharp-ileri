using EticaretApi.Domain.Entities._File;
using EticaretApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Domain.Entities
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        
        public float Price{ get; set; }
        public int Stock { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<ProductImageFile> ProductImageFiles { get; set; }  //Resimleri tuttugumuz yere bagladık 
    }
}
