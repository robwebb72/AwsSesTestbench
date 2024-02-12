namespace AwsSesTestbench.Models;

public record NotificationFilterModel
{
    public Guid? Id { get; set; }
    public DateTime? DateFrom { get; set; }
    public DateTime? DateTo { get; set; }
    public string NotificationType { get; set; } = string.Empty;
}