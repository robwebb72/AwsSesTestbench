using AwsSesTestbench.Entities;
using Microsoft.EntityFrameworkCore;

namespace AwsSesTestbench.Infrastructure;

public class AwsSesTestbenchDbContext : DbContext
{
    public DbSet<EmailNotification> EmailNotifications => Set<EmailNotification>();
    
    public AwsSesTestbenchDbContext(DbContextOptions options) : base(options)
    {
    }    
    
}