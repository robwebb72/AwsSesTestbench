using Amazon;
using Amazon.Runtime;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using AwsSesTestbench.AWS;
using AwsSesTestbench.Models;
using AwsSesTestbench.Models.AwsTemplates;

namespace AwsSesTestbench.Services;

public class AwsTemplateService
{
    public async Task<List<AwsTemplateIdModel>> GetTemplatesAsync(CancellationToken cancellationToken)
    {
        var snsCredentials = new BasicAWSCredentials(AwsKeys.Access, AwsKeys.SecretAccess);
        using var sesClient = new AmazonSimpleEmailServiceClient(snsCredentials, RegionEndpoint.EUWest1);

        var listTemplatesRequest = new ListTemplatesRequest
        {
            MaxItems = 100
        };
        var response = await sesClient.ListTemplatesAsync(listTemplatesRequest, cancellationToken);

        return response is null ? 
            new List<AwsTemplateIdModel>() :
            response.TemplatesMetadata.Select(MapTemplateMetadataToAwsTemplateIdModel).ToList();
    }

    private static AwsTemplateIdModel MapTemplateMetadataToAwsTemplateIdModel(TemplateMetadata templateMetadata)
        => new()
        {
            Name = templateMetadata.Name,
            TimeStamp = templateMetadata.CreatedTimestamp
        };

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