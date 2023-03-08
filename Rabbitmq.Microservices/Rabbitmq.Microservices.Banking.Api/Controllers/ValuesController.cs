using Microsoft.AspNetCore.Mvc;

namespace Rabbitmq.Microservices.Banking.Api.Controllers
{
    public class ValuesController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
