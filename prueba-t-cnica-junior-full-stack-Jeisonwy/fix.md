# Corrección de Falla

Describe:

* Qué error encontraste
* Por qué ocurría
* Cómo lo solucionaste





Respuesta detallada:





Encontré varios errores que impedían la conexión entre los dos microservicios, al principio tuve problemas intentando ejecutar http://localhost:5002/api/orders/ (daba error 404) pero caí en cuenta que esta ruta no estaba definida debía ir con la llave del dato para funcionar, una vez descarte eso vi que tenia un error 500 lo que me decía que algo estaba mal configurado, empecé por la revisión de el servicio de orders debido que al entrar a http://localhost:5000/api/users/4 (que es el de users mostraba información ósea al menos si mostraba lo que se debía ver.



Otro punto importante es el tema de los puertos, me estaba arrancando ambos servicios en el puerto 5000 por lo que solo podía tener uno activo esto se solucionó utilizando el 5002 para orders





lo primero fue revisar el orderservice, esto debió a su error 500 donde se simulo una respuesta para ver si se mostraba la información, y si se ya mostraba datos lo que significaba que funcionaba sin dependencias de red



luego se cambio el httpclient por IHttpClientFactory que es una interfaz que crea un cliente llamado UserApi, lo busca en program.cs y toma la configuración de allí y es reutiliazble, adicional se cambio en appsettings que estaba quemado directamente el localhost, ahora queda en la configuración la url base del microservicio



después tuve un problema con la comunicación ya que un microservicio hablaba en http y otro en https lo que impedia la conexión uno a otro, para el ejemplo se dejo todo sin el protocolo seguro https





Respuestas especificas:





Errores que había:

&#x09;Error 500 de servidor

&#x09;Error de la ruta invalida

&#x09;Choque de puertos

&#x09;Error en el protocolo de http y https



Por que ocurría:

&#x09;Error 500 de servidor: Por problemas en las rutas definidas

&#x09;Error de la ruta invalida: este se podría decir que la forma en la que se estaba utilizando el metodo no era la correcta

&#x09;Choque de puertos: Por que al ejecutar el primero ocupaba el espacio donde se debía ejecutar el segundo

&#x09;Error en el protocolo de http y https: Por falta de que coincidieran los protocolos



Cómo lo solucionaste:

&#x09;Error 500 de servidor: Se hizo la prueba con un objeto falso y luego se configuro BaseAddress para que supiera exactamente donde iniciar

&#x09;Error de la ruta invalida: Se modifico el constructor, se cambio en lugar de inyectar httpClient se inyecto ihttpClientFactory y se utilizo userApi para 	crear una conexión entre configuración y controlador

&#x09;Choque de puertos: Asignando el puerto 5000 para un servicio y 5002 para otro servicio

&#x09;Error en el protocolo de http y https: se normalizaron ambos protocolos dejándolos http



Respuesta compuesta:



{

&#x20; "orderId": 4,

&#x20; "product": "Laptop",

&#x20; "user": "{\\"id\\":1,\\"nombre\\":\\"Juan\\",\\"email\\":\\"juan@mail.com\\"}"

}



Parte 3 – Debug / Fix

Con respecto al Bug se identifico que si usersService no esta activo, orders va a fallar, se agrego una excepción que controla en fallo y muestra que no esta disponible, aunque no provoca fallas en tiempos de ejecución si evita la ejecución del servicio

