using Restorant.Application.ViewModel._Customer;
using Restorant.Domain.Entiteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.ViewModel._Worker
{
    public class VM_Worker_Login
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public static implicit operator VM_Worker_Login(Worker customer)
        {
            return new VM_Worker_Login
            {
                Email = customer.Email,
                Password = customer.Password
            };
        }
        public static implicit operator Worker(VM_Worker_Login customer)
        {
            return new Worker
            {
                Email = customer.Email,
                Password = customer.Password
            };
        }
    }
}
