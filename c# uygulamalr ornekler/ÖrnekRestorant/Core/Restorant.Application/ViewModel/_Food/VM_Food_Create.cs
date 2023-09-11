using Restorant.Domain.Entiteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.ViewModel._Food
{
    public class VM_Food_Create
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Exists { get; set; }

        public static implicit operator VM_Food_Create(Food food)
        {
            return new VM_Food_Create()
            {
                Description = food.Description,
                Price = food.Price,
                Name = food.Name,
                Exists = food.Exists
            };
        }
        public static implicit operator Food(VM_Food_Create food)
        {
            return new Food()
            {
                Description = food.Description,
                Price = food.Price,
                Name = food.Name,
                Exists = food.Exists
            };
        }
    }
}
