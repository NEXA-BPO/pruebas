# Correccion de fallas

## Error 1
- Qué error encontraste

Primero revise el csproj para ver la versio del .Net

- Por qué ocurría

Version 8

- Cómo lo solucionaste

Lo resolvi actualizando la version a la 10 tanto en OrderService como en UserService

## Error 2
- Qué error encontraste

Al intentar ejecutar los servicios, la aplicacion fallaba con invalid request URI, y por HttpClient

- Por qué ocurría

OrdersController declaraba HttpClient como dependencia en su contructor, pero Program, nunca lo registro en el contenedor de inyeccion de dependencias.{id},
eran rutas relativas, lo que tambien lo que tambien hubiese causado fallas  al consumir UserService

- Cómo lo solucionaste

Agregue el registro de HttpClient en Program usando AddHttpClient<OrdersController>(), leyendo la url base de UserService desde appsettings.json

## Error 3
- Qué error encontraste

Al arreglar lo anterior por el HttpClient, corri los dos servicios, el cual me salio error ya que los dos servicios estan corriendo en el mismo puerto

- Por qué ocurría

Mismo puerto en los dos servicios

- Cómo lo solucionaste

Se agrego la propiedad Urls en los settings de cada servicio, para OrderService use 5000 y para UserService use 5001

## Error 4
- Qué error encontraste

Volvi a correr los servicios donde se evidenciaba que corrian bien, pero al ejecutar una consulta como: http://localhost:5000/api/orders/1 fallaba el servicio
en AddHttpClient<OrdersController>()

- Por qué ocurría

Como los controladores funcionan distindo a los servicios, el HttpClient no se estaba inyectando bien

- Cómo lo solucionaste

Se cambio el enfoque a IHttpClientFactory en el program y se actualizo el OrdersController para recibirlo. ya al guardar y correr los servicios, se levantaron
bien, luego realice la prueba de http://localhost:5000/api/orders/1, para lo que salio el siguiente resultado:

{
"orderId": 1,
"product": "Laptop",
"user": "{\"id\":1,\"nombre\":\"Juan\",\"email\":\"juan@mail.com\"}"
}