using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Domain.Entities._File
{
    public class ProductImageFile :File
    {
        //illa tutmak gerekmez 
        public ICollection<Product> Products { get; set; }
    }
}
