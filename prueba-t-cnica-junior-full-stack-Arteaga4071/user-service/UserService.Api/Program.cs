var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddHttpClient("UserService", client =>
{
    client.BaseAddress = new Uri("http://localhost:5001/"); //ajuste de puerto
});

var app = builder.Build();

app.MapControllers();

app.Run();