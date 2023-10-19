using AwsSesTestbench.Services;

namespace AwsSesTestbench.Setup;

public static class ServicesSetup
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<AwsTemplateService>();
    }    
}