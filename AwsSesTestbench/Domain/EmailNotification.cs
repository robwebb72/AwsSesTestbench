using AwsSesTestbench.Domain.Enum;

namespace AwsSesTestbench.Domain;

public class EmailNotification
{
    public Guid Id { get; set; }
    public string MessageId { get; set; } = string.Empty;
    public  int Type { get; set; }
    public DateTime TimeStamp { get; set; } = DateTime.MinValue;
    public string OriginalJson { get; set; } = string.Empty;
    
    private EmailNotification() { }

    public EmailNotification(string messageId, string notificationName, DateTime timeStamp, string originalJson)
    {
        MessageId = messageId;
        Type = NotificationType.ValueFromName(notificationName);
        TimeStamp = timeStamp;
        OriginalJson = originalJson;
    }
}