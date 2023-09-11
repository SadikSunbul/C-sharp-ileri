using EticaretApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.ViewModels.Products
{
    public class VM_Create_Product
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }

        #region Veridonusumu 

        public static implicit operator VM_Create_Product(Product product)
        {
            return new VM_Create_Product()
            {
                Name = product.Name,
                Stock = product.Stock,
                Price = product.Price
            };
        }
        public static implicit operator Product(VM_Create_Product product)
        {
            return new Product()
            {
                Name = product.Name,
                Stock = product.Stock,
                Price = product.Price
            };
        }
        #endregion

    }
}
