namespace AwsSesTestbench.Domain;

public class EmailNotification
{
    public Guid Id { get; set; }
    public string MessageId { get; set; } = string.Empty;
    public string Notification { get; set; } = string.Empty;
    public DateTime TimeStamp { get; set; } = DateTime.MinValue;
    public string OriginalJson { get; set; } = string.Empty;
    
    private EmailNotification() { }

    public EmailNotification(string messageId, string notification, DateTime timeStamp, string originalJson)
    {
        MessageId = messageId;
        Notification = notification;
        TimeStamp = timeStamp;
        OriginalJson = originalJson;
    }
}