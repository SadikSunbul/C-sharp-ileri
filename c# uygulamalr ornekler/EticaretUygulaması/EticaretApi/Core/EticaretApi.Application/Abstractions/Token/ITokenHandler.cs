using EticaretApi.Application.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Abstractions
{
    public interface ITokenHandler
    {
        Token CreateAccessToken(int minute); //CreateAccessToken uretılen token jwt demek 

    }
}
