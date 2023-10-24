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
        var messageModel = JsonSerializer.Deserialize<AwsNotificationModel>(notificationString, jsonSerializerOptions);
        await Task.CompletedTask;

        var (success, resultString) = (messageModel?.Type) switch
        {
            "Notification" => (true, "handled notification"),
            "SubscriptionConfirmation" => (true, "dealt with subscription confirmation"),
            _ => (false, "unknown message type")
        };

        return success ? Ok(resultString) : BadRequest(resultString);
    }
}