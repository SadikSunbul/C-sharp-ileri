using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Exeptions
{
    public class NotFoundUserExeption:Exception
    {
        public NotFoundUserExeption():base("Kullanıcı adı veya Mail hatalı")
        {
            
        }
        public NotFoundUserExeption(string? message):base(message)
        {
            
        }

        public NotFoundUserExeption(string? message ,Exception? exception ):base(message, exception)
        {
            
        }
    }
}
