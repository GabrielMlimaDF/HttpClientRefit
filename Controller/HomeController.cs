using Microsoft.AspNetCore.Mvc;

namespace HttpClientApi.Controller
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
       
        [HttpGet("")]
        public ActionResult Get()
        {
            return Ok("Funcionando");
        }
    }
}
