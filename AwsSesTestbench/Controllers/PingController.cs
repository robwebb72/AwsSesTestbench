using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AwsSesTestbench.Controllers;

[ApiController]
[Route("")]
public class PingController : ControllerBase
{

    [HttpGet]
    [AllowAnonymous]
    [SwaggerOperation(Summary = "Default endpoint to service ping requests", Tags = new[] { "Ping" })]
    public ActionResult PingCheck()
    {
        return Ok();
    }
}