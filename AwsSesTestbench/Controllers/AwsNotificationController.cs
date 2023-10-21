using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AwsSesTestbench.Controllers;

[ApiController]
[Route("api/notification")]
public class AwsNotificationController : ControllerBase
{
    [HttpPost]
    [SwaggerOperation (Summary = "Handle Aws Notification", Tags = new[] {"Aws Notification"})]
    public async Task<ActionResult> ReceiveAwsNotification(CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        return Ok();
    }
}