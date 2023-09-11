using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Commends._AppUser.LoginUser
{
    public class LoginUserCommendRequest:IRequest<LoginUserCommendResponse>
    {
        public string UserNameOrMailk { get; set; }
        public string Password { get; set; }
    }
}
