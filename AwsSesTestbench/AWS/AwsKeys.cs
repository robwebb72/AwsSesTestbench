namespace AwsSesTestbench.AWS;

public static class AwsKeys
{
    public static string Access { get; private set; }= "";
    public static string SecretAccess { get; private set; }= "";

    public static void Initialise(AwsSettings awsSettings)
    {
        Access = awsSettings.AccessKey;
        SecretAccess = awsSettings.SecretAccessKey;
    }    
}