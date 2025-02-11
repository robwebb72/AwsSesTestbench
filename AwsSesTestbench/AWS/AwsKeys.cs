namespace AwsSesTestbench.AWS;

public static class AwsKeys
{
    public static string Access { get; private set; }= string.Empty;
    public static string SecretAccess { get; private set; }= string.Empty;

    public static void Initialise(AwsSettings awsSettings)
    {
        Access = awsSettings.AccessKey;
        SecretAccess = awsSettings.SecretAccessKey;
    }    
}