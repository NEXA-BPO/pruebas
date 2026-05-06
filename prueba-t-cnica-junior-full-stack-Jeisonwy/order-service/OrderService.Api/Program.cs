var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddHttpClient("UserApi", client =>
{client.BaseAddress = new Uri("http://localhost:5000/"); });

var app = builder.Build();



app.MapControllers();

app.Run();