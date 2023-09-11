using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.DTOS
{
    public class Token
    {
        public string AccessToken { get; set; }
        public DateTime Expiration { get; set; } //son bulma tarıhı 
    }
}
