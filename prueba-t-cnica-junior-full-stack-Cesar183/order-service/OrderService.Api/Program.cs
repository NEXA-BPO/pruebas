var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddHttpClient("UserService", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["Services:UserService:BaseUrl"]!);
});

var app = builder.Build();

app.MapControllers();

app.Run();