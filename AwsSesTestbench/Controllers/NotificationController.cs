using Microsoft.AspNetCore.Mvc;

namespace AwsSesTestbench.Controllers;

[Route("api/notification")]
[ApiController]
public class NotificationController : ControllerBase
{
    [HttpGet]

    [HttpPost]

    [HttpDelete("{notificationId}")]
    public async Task DeleteByIdAsync(Guid notificationId, CancellationToken cancellationToken)
    {
        
    }
}