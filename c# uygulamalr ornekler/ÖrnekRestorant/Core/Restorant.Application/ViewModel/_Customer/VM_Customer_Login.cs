using Restorant.Domain.Entiteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.ViewModel._Customer
{
    public class VM_Customer_Login
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public static implicit operator VM_Customer_Login(Customer customer)
        {
            return new VM_Customer_Login
            {
                Email = customer.Email,
                Password = customer.Password
            };
        }
        public static implicit operator Customer(VM_Customer_Login customer)
        {
            return new Customer
            {
                Email = customer.Email,
                Password = customer.Password
            };
        }
    }
}
