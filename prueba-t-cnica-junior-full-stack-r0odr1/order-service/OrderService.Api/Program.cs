using OrderService.Api.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var userServiceUrl = builder.Configuration["Services:UserService:BaseUrl"];
builder.Services.AddHttpClient("UserService", client =>
{
    client.BaseAddress = new Uri(userServiceUrl!);
});

var app = builder.Build();

app.MapControllers();

app.Run();