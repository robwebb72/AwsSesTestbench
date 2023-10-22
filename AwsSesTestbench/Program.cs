using AwsSesTestbench;
using AwsSesTestbench.AWS;
using AwsSesTestbench.Setup;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddServices();
builder.SetupDatabaseConnection();
builder.Services.AddAutoMapper(typeof(AwsSesTestbenchMarker).Assembly);

var awsSettings = builder.Configuration.GetSection("AwsSettings").Get<AwsSettings>();
AwsKeys.Initialise(awsSettings!);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Email Notify Test Gateway API");
    c.RoutePrefix = "api/documentation";
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();