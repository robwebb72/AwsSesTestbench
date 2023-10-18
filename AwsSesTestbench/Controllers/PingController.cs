using Microsoft.AspNetCore.Mvc;

namespace AwsSesTestbench.Controllers;

[ApiController]
[Route("[controller]")]
public class PingController : ControllerBase
{

    [HttpGet]
    public ActionResult Get()
    {
        return Ok();
    }
}