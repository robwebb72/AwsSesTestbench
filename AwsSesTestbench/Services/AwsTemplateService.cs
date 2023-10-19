using AwsSesTestbench.Models;
using AwsSesTestbench.Models.AwsTemplates;

namespace AwsSesTestbench.Services;

public class AwsTemplateService
{
    public async Task<List<AwsTemplateIdModel>> GetTemplatesAsync(CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        return new List<AwsTemplateIdModel>();
    }
    
    public async Task<(bool, string)> DeleteTemplateAsync(string name, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        return (true, $"Deleted template: {name}");
    }
 
    public async Task<(bool, string)> CreateTemplateAsync(AwsTemplateCreateModel model, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        var messageId = "<no-id>";
        return (true, $"Template created: {messageId}");
    }
}