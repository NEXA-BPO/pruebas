var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddHttpClient("UserService", client =>
    {
        var baseUri = builder.Configuration["Services:UserService:BaseUrl"]
            ?? throw new InvalidOperationException("No uri in configurations");
        client.BaseAddress = new Uri(baseUri);
    }
);

var app = builder.Build();

app.MapControllers();

app.Run();