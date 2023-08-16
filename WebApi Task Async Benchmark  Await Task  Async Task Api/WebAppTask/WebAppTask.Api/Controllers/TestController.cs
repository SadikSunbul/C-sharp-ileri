using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppTask.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        [Route("sync")]
        public IActionResult GetSync() //tred olsuturarak yapar bunu 
        {
            Thread.Sleep(1000); //senkron bekledik
            return Ok();
        }

        [HttpGet]
        [Route("async")]
        public async Task<IActionResult> GetAsync() 
        {
            await Task.Delay(1000); //asenkron bekledık
            return Ok();
        }
    }
}
