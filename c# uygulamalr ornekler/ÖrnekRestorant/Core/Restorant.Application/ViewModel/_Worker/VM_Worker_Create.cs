using Restorant.Application.ViewModel._Customer;
using Restorant.Domain.Entiteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.ViewModel._Worker
{
    public class VM_Worker_Create
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Addres { get; set; }
        public int Wage { get; set; }

        public static implicit operator VM_Worker_Create(Worker customer)
        {
            return new VM_Worker_Create
            {
                Email = customer.Email,
                Password = customer.Password,
                Addres = customer.Addres,
                Name = customer.Name,
                Phone = customer.Phone,
                Surname = customer.Surname,
                Wage = customer.Wage
            };
        }
        public static implicit operator Worker(VM_Worker_Create customer)
        {
            return new Worker
            {
                Email = customer.Email,
                Password = customer.Password,
                Addres = customer.Addres,
                Name = customer.Name,
                Phone = customer.Phone,
                Surname = customer.Surname,
                Wage = customer.Wage
            };
        }
    }
}
