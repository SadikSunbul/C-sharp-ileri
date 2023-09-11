using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Domain.Entities._Identity
{
    public class AppUser:IdentityUser<string>
    {
        public string NamwSurnaem { get; set; }
    }
}
