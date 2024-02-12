using AwsSesTestbench.Domain.Enum;

namespace AwsSesTestbench.Domain;

public class EmailNotification
{
    public Guid Id { get; private set; }
    public string MessageId { get; private set; } = string.Empty;
    public  NotificationType Type { get; private set; }
    public DateTime TimeStamp { get; private set; } = DateTime.MinValue;
    public string OriginalJson { get; private set; } = string.Empty;
    
    private EmailNotification() { }

    public EmailNotification(string messageId, string notificationName, DateTime timeStamp, string originalJson)
    {
        MessageId = messageId;
        Type = NotificationType.FromName(notificationName);
        TimeStamp = timeStamp;
        OriginalJson = originalJson;
    }
}