using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Service2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await Task.Delay(15000);// boyle calsıtırldıgında servıs 1 buraya ıstek atıcak ve 15 sn beklıycek sonra cıktııy alıcak bu radakı yaklasımınız senkron yaklasımdır
            return Ok(123);
        }
    }
}
