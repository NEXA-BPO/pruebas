# Corrección de Falla

Describe:

- Qué error encontraste
- Por qué ocurría
- Cómo lo solucionaste

## ¿Qué estaba fallando?

El OrderService mostraba error 500 al llamar al endpoint GET /api/orders/{id}.
Al revisar el código se encuentra que en Program.cs no estaba registrado
el HttpClient y en el controller se estaba inyectando HttpClient
directamente sin tener una BaseAddress configurada. Esto ocasionaba que
al intentar llamar al UserService fallara porque no sabía a qué
URL apuntar.

## ¿Qué se modificó?

En Program.cs se agregó el registro del HttpClient con el nombre
"UserService" y la URL base del servicio:

```
builder.Services.AddHttpClient("UserService", client =>
{
    client.BaseAddress = new Uri("http://localhost:5001/");
});
```

En el controller se realizó el cambio en la inyección de HttpClient por IHttpClientFactory
para poder crear el cliente con la configuración correcta:

```
public OrdersController(IHttpClientFactory httpClientFactory)
{
    _httpClient = httpClientFactory.CreateClient("UserService");
}
```

## ¿Cómo se verificó que funcionó?

Se realizó la prueba en Postman:

- GET http://localhost:5000/api/orders/1 → 200 OK, retorna la orden
  con los datos del usuario del UserService
- GET http://localhost:5001/api/users/1 → 200 OK, UserService responde
