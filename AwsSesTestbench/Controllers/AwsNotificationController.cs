using System.Text.Json;
using AwsSesTestbench.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AwsSesTestbench.Controllers;

[ApiController]
[Route("api/notification")]
public class AwsNotificationController : ControllerBase
{
    [HttpPost]
    [SwaggerOperation (Summary = "Handle Aws Notification", Tags = new[] {"Aws Notification"})]
    [Consumes("text/plain")]
    public async Task<ActionResult<string>> ReceiveAwsNotification([FromBody] string notificationString, CancellationToken cancellationToken)
    {
        var jsonSerializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var messageModel = JsonSerializer.Deserialize<AwsMessageModel>(notificationString, jsonSerializerOptions);
        await Task.CompletedTask;
        return Ok(notificationString);
    }
}