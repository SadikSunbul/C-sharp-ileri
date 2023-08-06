using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje.Application.Features.Cars.Command.Create;
using Proje.Application.Features.Cars.Command.Delete;
using Proje.Application.Features.Cars.Queries.GetById;
using Proje.Application.Features.Cars.Queries.GetList;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : BaseController
    {
        
        //BaseController den turedıgı ıcın medıator kendısınden gelicektir 

        [HttpPost]
        public async Task<IActionResult> CreateCar([FromBody] CreateCarCommandRequest request)
        {
            CreateCarCommandRespons respons = await Mediator.Send(request);
            return Ok(respons);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletedCar([FromBody] DeletedCarCommandRequest request)
        {
            var respons = await Mediator.Send(request);
            return Ok(respons);
        }

        [HttpGet]
        public async Task<IActionResult> GetListCar([FromQuery] GetListCaQueryRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);
        }

        [HttpGet("listDynamic")]
        public async Task<IActionResult> GetListByCar([FromQuery] GetDynamicListCarRequest request)
        {
            var data = await Mediator.Send(request);
            return Ok(data);
        }
    }
}
