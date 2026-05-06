## Error 1: Inyección de dependencias

El OrderService generaba una excepción al intentar usar IHttpClientFactory.

### Causa
El servicio HttpClient no estaba registrado en el contenedor de dependencias.

### Solución
Se registró el servicio utilizando AddHttpClient en Program.cs, permitiendo una correcta inyección en el controlador.


## Error 2: Comunicación entre microservicios

El OrderService no podía comunicarse con el UserService.

### Causa
El UserService se ejecutaba en un puerto diferente al configurado en el HttpClient.

### Solución
Se unificó el puerto del UserService con el configurado en el HttpClient, asegurando la correcta comunicación, para ejecutar se usó "dotnet run --urls=http://localhost:5001" y así podemos ver los datos que trae en ambos puertos, trae los datos con normalidad.


## Error 3: Manejo de respuesta HTTP

Se producía un error al procesar la respuesta del UserService yno permitia su correcto funcionamiento.

### Causa
No se validaba el estado de la respuesta antes de reconstruir el contenido.

### Solución
Se agregó validación de IsSuccessStatusCode antes de procesar la respuesta y así el problema quedó solucionado.
