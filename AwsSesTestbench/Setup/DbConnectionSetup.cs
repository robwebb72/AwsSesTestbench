using AwsSesTestbench.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace AwsSesTestbench.Setup;

public static class DatabaseConnectionSetup
{
    const bool UseRemoteDb = false;

    public static void SetupDatabaseConnection(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString(UseRemoteDb ? "Remote": "Local");
        builder.Services.AddDbContext<AwsSesTestbenchDbContext>(opt => opt.UseSqlServer(connectionString));        
    }
}