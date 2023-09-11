using EticaretApi.Application.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Commends._AppUser.LoginUser
{
    public class LoginUserCommendResponse
    {
        //hata gelınce veya gırıs yapınca farklı yerler tetıklencek
    }
    public class LoginUserSuccsessCommendResponse: LoginUserCommendResponse
    {
        public Token Token { get; set; }
    }
    public class LoginUserErorsCommendResponse: LoginUserCommendResponse
    {
        public string Message { get; set; }
    }
}
