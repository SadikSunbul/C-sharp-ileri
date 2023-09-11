using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Exeptions
{
    public class AuthenticationErrorException:Exception
    {
        public AuthenticationErrorException():base("Kımlık dogrulama hatası")
        {
            
        }
        public AuthenticationErrorException(string message):base(message) 
        {
            
        }
        public AuthenticationErrorException(string message,Exception? exception ):base(message,exception) 
        {
            
        }
    }
}
