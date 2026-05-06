var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var userServiceBaseUrl =
    builder.Configuration["Services:UserService:BaseUrl"]
    ?? "http://localhost:5001";

builder.Services.AddHttpClient("UserService", client =>
{
    client.BaseAddress = new Uri(userServiceBaseUrl);
});

var app = builder.Build();

app.MapControllers();

app.Run();