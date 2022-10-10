using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using OCL.ApiGateway;

var builder = WebApplication.CreateBuilder(args);




builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddJaeger(builder.Configuration);
var app = builder.Build();
await app.UseOcelot();

app.MapGet("/", () => "Hello World!");

app.Run();
