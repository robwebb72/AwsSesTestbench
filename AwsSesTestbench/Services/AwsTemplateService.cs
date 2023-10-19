using AwsSesTestbench.Models;

namespace AwsSesTestbench.Services;

public class AwsTemplateService
{
    public async Task<List<AwsTemplateIdModel>> GetTemplatesAsync(CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        return new List<AwsTemplateId>();
    }
}