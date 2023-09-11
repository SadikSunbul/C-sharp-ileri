using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Exeptions
{
    public class UserCreateFailedExeption : Exception
    {
        public UserCreateFailedExeption():base("Kullanıcı olusturulurken beklenmedık bır hata ıle karsılasıldı")
        {
            
        }
        public UserCreateFailedExeption(string? message):base(message)
        {

        }

        public UserCreateFailedExeption(string? message, Exception? innerException) : base(message,innerException)
        {
            
        }
    }
}
