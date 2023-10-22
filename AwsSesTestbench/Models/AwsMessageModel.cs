namespace AwsSesTestbench.Models;


public record AwsMessageModel
{
    public string Type { get; set; } = "";
    public string TopicArn { get; set; } = "";
    public string Token { get; set; } = "";
    public string Message { get; set; } = "";
}