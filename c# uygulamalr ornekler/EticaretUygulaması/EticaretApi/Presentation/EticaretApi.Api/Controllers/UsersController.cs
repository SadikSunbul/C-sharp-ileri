using EticaretApi.Application.Features.Commends._AppUser.CreateUser;
using EticaretApi.Application.Features.Commends._AppUser.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EticaretApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class UsersController : ControllerBase
    {
        public IMediator Mediator { get; }

        public UsersController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromQuery]CreateUserCommendRequest createUserCommendRequest)
        {
            var data = await Mediator.Send(createUserCommendRequest);
            return Ok(data);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(/*[FromQuery]*/LoginUserCommendRequest loginUserCommendRequest)
        {
            var data=await Mediator.Send(loginUserCommendRequest);
            return Ok(data);
        }
    }
}
