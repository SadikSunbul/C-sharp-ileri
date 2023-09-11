using Restorant.Domain.Entiteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.ViewModel._Customer
{
    public class VM_Customer_Create
    {
        public string İsim { get; set; }
        public string Soyisim { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        #region Donusum

        public static implicit operator VM_Customer_Create(Customer customer)
        {
            return new VM_Customer_Create()
            {
                Email = customer.Email,
                Password = customer.Password,
                Phone = customer.Phone,
                Soyisim = customer.Soyisim,
                İsim = customer.İsim
            };
        }

        public static implicit operator Customer(VM_Customer_Create customer)
        {
            return new Customer()
            {
                Email = customer.Email,
                Password = customer.Password,
                Phone = customer.Phone,
                Soyisim = customer.Soyisim,
                İsim = customer.İsim
            };
        }

        #endregion
    }
}
