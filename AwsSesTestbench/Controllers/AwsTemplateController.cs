using AwsSesTestbench.Models;
using AwsSesTestbench.Models.AwsTemplates;
using AwsSesTestbench.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

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
    [SwaggerOperation(Summary = "Get list of AWS SES Templates", Tags = new[] { "AWS Email Template" })]
    public async Task<ActionResult<List<AwsTemplateIdModel>>> GetTemplateAsync(CancellationToken cancellationToken)
    {
        var result = await _awsTemplateService.GetTemplatesAsync(cancellationToken);
        return Ok(result);
    }
    
    [HttpDelete]
    [SwaggerOperation(Summary = "Delete AWS SES Template", Tags = new[] { "AWS Email Template" })]
    public async Task<ActionResult<string>> DeleteTemplateAsync(string name, CancellationToken cancellationToken)
    {
        var (success, output) = await _awsTemplateService.DeleteTemplateAsync(name, cancellationToken);
        return success ? Ok(output) : BadRequest(output);
    }
    
    [HttpPost]
    [SwaggerOperation(Summary = "Create AWS SES Template", Tags = new[] { "AWS Email Template" })]
    public async Task<ActionResult<string>> CreateTemplateAsync(AwsTemplateCreateModel model, CancellationToken cancellationToken)
    {
        var (success, output) = await _awsTemplateService.CreateTemplateAsync(model, cancellationToken);
        return success ? Ok(output) : BadRequest(output);
    }
    
}