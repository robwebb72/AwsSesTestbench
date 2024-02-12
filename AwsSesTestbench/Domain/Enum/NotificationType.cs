using System.Runtime.CompilerServices;

namespace AwsSesTestbench.Domain.Enum;

public class NotificationType
{
    public int Value { get; private set; }
    public string Name { get; private set; }
    
    public static readonly NotificationType Sent = new(1);
    public static readonly NotificationType Delivered = new(2);
    public static readonly NotificationType Opened = new(3);
    public static readonly NotificationType Clicked = new(4);
    public static readonly NotificationType Bounced = new(5);
    public static readonly NotificationType Complaint = new(6);
    public static readonly NotificationType Unknown= new(7);

    private NotificationType(int value, [CallerMemberName] string name = "")
    {
        Value = value;
        Name = name;
    }

    public static NotificationType FromName(string name)
    {
        if (string.Compare(name, nameof(Sent), StringComparison.OrdinalIgnoreCase) == 0)
            return Sent;
        if (string.Compare(name, nameof(Delivered), StringComparison.OrdinalIgnoreCase) == 0)
            return Delivered;
        if (string.Compare(name, nameof(Opened), StringComparison.OrdinalIgnoreCase) == 0)
            return Opened;
        if (string.Compare(name, nameof(Clicked), StringComparison.OrdinalIgnoreCase) == 0)
            return Clicked;
        if (string.Compare(name, nameof(Bounced), StringComparison.OrdinalIgnoreCase) == 0)
            return Bounced;
        if (string.Compare(name, nameof(Complaint), StringComparison.OrdinalIgnoreCase) == 0)
            return Complaint;
        if (string.Compare(name, nameof(Unknown), StringComparison.OrdinalIgnoreCase) == 0)
            return Unknown;
        throw new ArgumentException($"Notification Type '{name}' not recognised");
    }
}