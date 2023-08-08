using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje.Application.Features.Brands.Commends.Create;
using Proje.Application.Features.Brands.Commends.Delete;
using Proje.Application.Features.Brands.Commends.Update;
using Proje.Application.Features.Brands.Queries.GetById;
using Proje.Application.Features.Brands.Queries.GetList;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : BaseController
    {

        [HttpPost]
        public async Task<IActionResult> BrandCreate([FromBody] CreateBrandCommandRequest request)
        {
            var respons = await Mediator.Send(request);
            return Ok(respons);
        }

        [HttpDelete]
        public async Task<IActionResult> BrandDelete([FromQuery] DeleteBrandCommandRequest request)
        {
            var respons = await Mediator.Send(request);
            return Ok(respons);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateBrandCommandRequest request)
        {
            var respons = await Mediator.Send(request);

            return Ok(respons);
        }

        [HttpGet]
        public async Task<IActionResult> GetListPage([FromQuery] GetListBrandQueryRequest request)
        {
            var resposn = await Mediator.Send(request);
            return Ok(resposn);
        }

        [HttpGet("byId")]
        public async Task<IActionResult> GetListPage([FromQuery] GetByBrandRequest request)
        {
            var resposn = await Mediator.Send(request);
            return Ok(resposn);
        }
    }
}
