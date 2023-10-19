using AwsSesTestbench.Models;
using AwsSesTestbench.Services;
using Microsoft.AspNetCore.Mvc;

namespace AwsSesTestbench.Controllers;

[ApiController]
[Route("api/template")]
public class AwsTemplateController : ControllerBase
{
    private readonly AwsTemplateService _awsTemplateService;

    public AwsTemplateController(AwsTemplateService awsTemplateService)
    {
        _awsTemplateService = awsTemplateService;
    }

    [HttpGet]
    public async Task<ActionResult<List<AwsTemplateId>>> GetTemplateAsync(CancellationToken cancellationToken)
    {
        var result = await _awsTemplateService.GetTemplatesAsync(cancellationToken);
        return Ok(result);
    }
}