# Parte Teórica

## .NET
1. ¿Qué es una API REST y qué métodos HTTP conoces?
   Un API REST es una Interfaz de Programacion paea aplicaciones, su funcion pricipalmete en poder comunicar a traves client to backend
   mediante un estandar como el que es REST. Lo mestodos HTTP que conoezco son 

   - GET: Llamar informacion
   - POST: Enviar informacion modificar, actulizar eliminar
   - PUT: Actualizacion compltea
   - PATCH: Actualizacion parcial
   - DELETE: Eliminacion
   
3. ¿Qué diferencia hay entre un DTO y un modelo de dominio?

   DTO: Es data transfer objetct, este se usa para poder enviar datos entre capas.
   Modelo de dominio: Es una respresentacion de la logica de nefocio
   
5. ¿Qué es la inyección de dependencias y para qué se utiliza?

   La inyeccion de dependencias, es cuando se quiere llamar a una dependencia por parte de una clase, osea no construir en el componente, digamos que deseo llamar una fucnion para auteticar, no solo la llamo con un new. Utilizo dentro del contructor de esa clase una instancia de la clase que quiero llamar y el framework se encarga de hacer la creacion

   Puede usarse para llamar multiples servicios de varios modulos, sin tener que llamarlos ahi mismo o por otro lado se puede hacer mediante modulos
   
7. ¿Para qué sirve el archivo appsettings.json?

   Sirve para la configuraciones dentro de .NET
   
9. Diferencia entre IEnumerable y List.

  IEnumerable: Lo podemos utilizar para un llamado una vez y leer los datos del mismo, por ejemplo llame datos que son una lisat a tares d eun API, con esto lo puedo trabajar con un performance alto

  List: Es mas para tratar los datos, poder agregar, modificar o actualizar sin problema, aunque con menor performance que un IEnumerable
    
## SQL Server
6. ¿Qué es una clave primaria?

   Una clave primaria es una forma en la cual le hago la identificacion a una columa de la base de datos con esto esta se encarga de comprobar que no haya filas identicas
   
8. Diferencia entre INNER JOIN y LEFT JOIN.

   Un INNER JOIN, se utiliza para llamar los datos que resultan de agrupar dos tablas distintas bajo ciertas caractaristicas, como el mismo id o bajo una llave foranea, pero esta me trae solo las coincidencias

   Un LEFT JOIN, tiene cierta similitud porque me trae datos de ambas tablas, pero tambien me trae en las que no hay conincidencias, entonces no solo llamo los datos de os que compartes ambas si no, lo que compartes y lo que en base a la primera tabla
   
10. ¿Para qué sirve un índice en una base de datos?

    El indice sirve para tener una especie de directorio de ciertas columnas, para poder hacer consultas mas rapido, pero dificilta la insersion de datos
    
12. ¿Qué significa normalizar una base de datos?

    Segun tengo entendido el normalziar una base de datos es la estandarizacion de la base de datos refrente al nombre de las tablas y columnas
    
14. Escribe una consulta SQL que obtenga los usuarios activos de una tabla Users.

    SELECT * FROM users AS u WHERE u.active = 1; 

## Git / GitHub
11. ¿Qué es Git y para qué se utiliza?

    Git es un sistema de control de versiones, se usa para tener un punto deguardado seguro para el codigo y si es el caso poder volver a el sin problema
    
13. Diferencia entre commit, push y pull.

    Commit: El nombre o mensaje de este punto deguardado
    push: Lleve ultimas versiones del sistema de control de versiones local, osea los commits creados hacia el repositorio
    pull: Trae ultimas versiones desde el repositorio desde lugares como github, gitlab o bitbuket
    
15. ¿Qué es un branch?

    Es una rama se usa para trabajar en paralelo con distintas version si afectar la pricipal, es como tener varias versiones del codigo, en distintos ambientes
    
17. ¿Para qué sirve un Pull Request?

    Pull Request: Sirve para poder enviar datos de una rama a otra, por ejemplo, si tengo una rama con una version o con cambios espesificos que deben subir a produccion creao un Pull Request para llevar eso cambios a una rama existente
    
19. ¿Qué problema resuelve GitHub Classroom?

    Github Classrom sirve para llevar a cambo pruebas tecnicas y ensernaza dentro de github
    

## Angular
16. ¿Qué es Angular?

    Es un framework de desarrollo frontend, con el cual se crean aplicaciones de forma modular
    
18. Diferencia entre component y service.

    component: Es la parte que interactua con el HTML tiene regla de negocio sencillas solo para la parte grafica
    service: Esta parte se centra en la logica del negocio a nivel de front, como llamar a API o trabajar con datos, no tiene parte garfica
    
20. ¿Para qué sirve ngOnInit?

    Sirve para poder realiza acciones cuando se inicializa el componente, como llamar datos o inicializar varibles pero solo cunaod se inicializa el componente
    
22. ¿Qué es data binding?

    El binding, se usa llevar datos del componente osea el codigo Typescript al HTML
    
24. Diferencia entre *ngIf y *ngFor.

    *ngIf: Se usa para condiciones y mostrar contenido cuando se cumplen o no
    *ngFor: Se usa para iterar cierto contenido que venga por parte del componente
    

## Postman / HTTP
21. ¿Para qué se utiliza Postman?

    Se utiliza para realizar petiones (HTTP, SOAP, GRAPH) con la finalidad de ver el funcionamiento de las APIs, siendo cleinte
    
23. ¿Qué es un status code HTTP?

    Es el codigo que devuelve una peticion HTTP, mostrar cual es el estado de la peticion en base a lo que llegue todo en basa a un estandar
    
25. Nombra y explica brevemente los códigos 200, 400 y 500.

    200: Es un OK, significa que la peticion fue exitosa
    400: Error, es un error relacionado a al envio de informacion por parte del cliente
    500: Internal Server Error, es un error del lado del servidor
    
27. Diferencia entre GET y POST.

    GET: Sirve para llamar datos
    POST: Sirve para enviar datos ya sea modificando, actualizando o eliminando
    
29. ¿Qué es un header en una petición HTTP?

    Header: Estos se envaian en la peticion como parametros que pueden ser para autorizacion, saber de donde viene la con un origin y traen la matadata

# Parte Teórica – Microservicios (.NET)
26. ¿Qué es un microservicio?

  microservicio: Se puede tratar como parte de un todo, es un servicio con una funcion clara, con sus propios endpints y desacoplado de otras funcionalidades. Ejemplo un servcio de autenticacion, el llamado solo para ello y no esta dentro de procesos internos de otro microservcio ni en su logica de negocio
    
28. Diferencia entre arquitectura monolítica y microservicios.

    Monolito: Estrautura que es poco modular, se centra en tener toda la logica y servicios en un solo logar intereactuando entra si
    microservicios: Estan desacoplados los servicios, uno no depende de otro para funcionar. Pero si interactuan entre si
    
30. ¿Cómo se comunican normalmente dos microservicios?

    Depende, lo pricipal es el orquestamineto de los microservicios. Se tienden a comunicar por HTTP, pero tambien se puede mendiante GRPC al ser mas rapido y usae HTTP2
    
32. ¿Qué es HTTP y para qué se utiliza?

    HTTP se utiliza para transmicion de datos a traves de una red
    
34. ¿Qué es una API REST?

    Un API REST es una Interfaz de Programacion paea aplicaciones la cual su funcion pricipalmete en poder comunicar a traves client to backend mediante un estandar como el que es REST
   
37. ¿Qué es inyección de dependencias?

     La inyeccion de dependencias, es cuando se quiere llamar a una dependencia por parte de una clase, osea no construir en el componente
    
39. ¿Qué es HttpClient y para qué sirve?

    HttpClient es una libreria que se configura y utiliza para realizar peticones HTTP hacia otros servcios o API externas
    
41. ¿Qué es un status code HTTP?

   Un status code HTTP es el codigo que devuelve una peticion HTTP, mostrar cual es el estado de la peticion en base a lo que llegue todo en basa a un estandar
    
42. ¿Qué significa un error 500?

    El error 500 es un Internal Server Error, es el error del lado del servidor
    
44. ¿Por qué es importante el versionado de dependencias?

    Es importante debido a que al tener el versionado se puede llevar un control de las mismas y ya que estas estan en cambio constante tenerlas versionadas permite un mejor manejo de las mismas, evitando pricipalmente vulenarabilidades y mejorando el mantenimiento
