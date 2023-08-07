using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje.Application.Features.Brands.Queries.GetList;
using Proje.Application.Features.Models.Queries.GetList;
using Proje.Application.Features.Models.Queries.GetListByDynamic;
using Proje.Domain.Core.Applicatioın.Repuest;
using Proje.Domain.Core.Applicatioın.Respons;
using Proje.Domain.Core.Persistance.Dynamic;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> GetListPage([FromQuery] GetListModelListItemRequest request)
        {
            var resposn = await Mediator.Send(request);
            return Ok(resposn);
        }

        [HttpPost("getlist/bydynamic")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery)
        {
            GetListByDynamicRequest getListModelQuery = new() { PageRequest = pageRequest, dynamicQuery = dynamicQuery };
            GetListRespons<GetListByDynamicDto> respons = await Mediator.Send(getListModelQuery);
            return Ok(respons);
        }
    }
}
