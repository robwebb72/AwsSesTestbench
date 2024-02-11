namespace AwsSesTestbench.Domain.Enum;

public static class NotificationType
{
    private static readonly Dictionary<int, string> Map = new();

    static NotificationType()
    {
        Map.Add(0, "sent");        
        Map.Add(1, "delivered");        
        Map.Add(2, "opened");        
        Map.Add(3, "clicked");        
        Map.Add(4, "bounced");        
        Map.Add(5, "complaint");        
        Map.Add(6, "unknown");        
    }

    public static int ValueFromName(string name)
    {
        foreach (var pair in Map)
            if (string.Equals(pair.Value, name, StringComparison.CurrentCultureIgnoreCase))
                return pair.Key;
        throw new ArgumentException($"No Notification Type with a name of {name} found");
    }
    
    public static string NameFromValue(int key)
    {
        if (Map.TryGetValue(key, out var name))
            return name;
        throw new ArgumentException($"No Notification Type with a value of '{key}' found");
    }
}