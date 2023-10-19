namespace AwsSesTestbench.Models.AwsTemplates;

public record AwsTemplateCreateModel
{
    public string TemplateName { get; init; } = string.Empty;
    public string Subject { get; init; } = string.Empty;
    public string TextPart { get; init; } = string.Empty;
    public string HtmlPart { get; init; } = string.Empty;
}