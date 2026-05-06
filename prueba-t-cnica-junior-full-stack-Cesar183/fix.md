# Corrección de Falla

## Error encontrado

En `OrderService.Api/Controllers/OrdersController.cs`, el constructor recibía un `HttpClient` directamente por inyección de dependencias:

```csharp
public OrdersController(HttpClient httpClient)
{
    _httpClient = httpClient;
}
```

Sin embargo, en `Program.cs` no había ningún registro de `HttpClient` en el contenedor de DI.

## Por qué ocurría

Al recibir cualquier request a `GET /api/orders/{id}`, ASP.NET Core intentaba resolver `HttpClient` del contenedor de DI para instanciar `OrdersController`, pero como nunca fue registrado, lanzaba la siguiente excepción en tiempo de ejecución:

```
InvalidOperationException: Unable to resolve service for type 'System.Net.Http.HttpClient'
while attempting to activate 'OrderService.Api.Controllers.OrdersController'
```

El servicio arrancaba sin errores, pero fallaba en el primer request recibido.

## Cómo se solucionó

Se reemplazó la inyección directa de `HttpClient` por `IHttpClientFactory`, que sí está disponible en DI por defecto. Además, se registró un cliente nombrado `"UserService"` en `Program.cs` con la `BaseAddress` leída desde `appsettings.json`:

```csharp
// Program.cs
builder.Services.AddHttpClient("UserService", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["Services:UserService:BaseUrl"]!);
});
```

```csharp
// OrdersController.cs
public OrdersController(IHttpClientFactory httpClientFactory)
{
    _httpClientFactory = httpClientFactory;
}

// Dentro del action:
var client = _httpClientFactory.CreateClient("UserService");
```

Esto resuelve dos problemas: la excepción de DI y el fallo por URL relativa sin `BaseAddress` configurada.
