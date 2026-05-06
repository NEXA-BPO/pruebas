# Parte Teórica

## .NET

######
1. ¿Qué es una API REST y qué métodos HTTP conoces?
# .Respuesta 1: Un API Rest es una tecnologia que permite conectar diferentes sistemas para que exista una comunicación entre diferentes tecnologias, los metodos HTTP son vitales ya que permiten la comunicacion entre frontend con el backend que a su vez controla tanto la base de datos como la logica de negocio, existen metodos (o peticiones) HTTP como GET (sirve para obtener los datos) POST (Sirve para Enviar datos) DELETE (Borrar datos) PUT (Para actualizar) existen mas metodos sin embargo estos son los escenciales en todo backend 
######


######
2. ¿Qué diferencia hay entre un DTO y un modelo de dominio?
# .Respuesta 2: la principal diferencia es que el DTO va a representar los datos que se van a procesar mientras que el modelo de dominio es basicamente una forma de definir los datos del negocio
######

######
3. ¿Qué es la inyección de dependencias y para qué se utiliza?
# .Respuesta 3: la inyección de dependecias es basicamente indicarle al proyecto de donde va a extraer o consultar las tecnologias que va a usar asi como su versión, esto es utilizado para que al momento de usar un framework o una librearia en el codigo el sistema al momento de compilar pueda conectarse a estas tecnologias
#######

#######
4. ¿Para qué sirve el archivo appsettings.json?
# .Respuesta 4: En un proyecto .NET el appsettigs.json, va a servir para indicarle (al momento de ejecutar) las configuraciones globales o dependencias que va a tener, aca por ejemplo va el string de conexión a la base de datos, librerias que se utilizaran con la respectiva version que se utilice 
#######

#######
5. Diferencia entre IEnumerable y List.
# .Respuesta 5: Ambas son colecciones de datos sin embargo ienumerable es algo mas complejo que list ya que funciona como una interfaz
#######


## SQL Server


#######
6. ¿Qué es una clave primaria?
# .Respuesta 6: Una Clave primaria en una base de datos es el dato principal o la forma en la que se va a identificar cada fila en la base de datos, en una base de datos la clave primaria no puede repetirse, no puede actualizarse y cada fila debe tener una en especifico
#######


#######
7. Diferencia entre INNER JOIN y LEFT JOIN.
# .Respuesta 7: En bases de datos al hacer consultas existen diferentes formas de combinar las tablas, en este caso inner join es  traer lo que coincide en ambas tablas, mientras que Left join es traer unicamente lo que encuentre en la tabla de la 'izquierda'
#######

#######
8. ¿Para qué sirve un índice en una base de datos?
# .Respuesta 8: El indice sirve para ayudarle al motor de base de datos a encontrar una fila sin recorrer toda la tabla, esto cobra sentido cuando la tabla es muy grande 
#######

#######
9. ¿Qué significa normalizar una base de datos?
# .Respuesta 9: Es basicamente organizar una base de datos a nivel de estructura para evitar errores como duplicidad o inconsistencias, es como acoplarla a buenas practicas 
#######

#######
10. Escribe una consulta SQL que obtenga los usuarios activos de una tabla Users.
# .Respuesta 10: consulta SQL para obtener usuarios activos (col de activo va a ser estado para el ejemplo)  : SELECT * FROM Users WHERE estado = 'Activo'
#######

## Git / GitHub

#######
11. ¿Qué es Git y para qué se utiliza?
# .Respuesta 11: Git es una tecnologia utilizada para el control de cambios en proyectos de desarrollo, es utilizada para llevar el control de los cambios realizados en todo el proyecto, creación de versiónes, permite el trabajo de varias personas en un mismo proyecto y todo esto de alguna forma va quedando documentado
#######

#######
12. Diferencia entre commit, push y pull.
# .Respuesta 12: Commit es para hacer comentarios (de los cambios que se hizo) Push es para actualizar una rama de un proyecto de golpe, y Pull es para solicitar que los cambios que esten actualizados en remoto se descarguen a local (todos estos son comandos)
#######

#######
13. ¿Qué es un branch?
# .Respuesta 13: Branch en git son las ramas que se crean para trabajar y tener diferentes versiones del codigo, de esta forma dos personas que trabajan en un proyecto pueden trabajar independientemente sin dañar los avances de otro por ejemplo 
#######

#######
14. ¿Para qué sirve un Pull Request?
# .Respuesta 13: Pull request es enviar cambios a un proyecto pero solicitando la revision de los cambios , si son aceptados esta pull request va a actualizar el proyecto
#######

#######
15. ¿Qué problema resuelve GitHub Classroom?
# .Respuesta 15: Uso Github sin embargo nunca me habia familiarizado con con esta sección

#######


## Angular

#######
16. ¿Qué es Angular?
# .Respuesta 16: Angular es un Marco de trabajo de Frontend que es uno de los mas utilizados a nivel global, esto debido a las buenas practicas que te obliga a llevar para la realizacion de proyectos
#######

#######
17. Diferencia entre component y service.
# .Respuesta 17: Un component es la estructura de la vista que se va a visualizar en la web y un service es donde va la logica como la conexion de api , esto se hace para que el proyecto sea mas ordenado
#######

#######
18. ¿Para qué sirve ngOnInit?
# .Respuesta 18: Para iniciar un proyecto de Angular
#######

#######
19. ¿Qué es data binding?
# .Respuesta 19: es la forma de conectar un componente de typescript con el html 

#######
20. Diferencia entre *ngIf y *ngFor.
# .Respuesta 20: sirve para mostar o ocultar partes en la pagina web

#######
## Postman / HTTP

#######
21. ¿Para qué se utiliza Postman?
# .Respuesta 21: Se utiliza principalmente para probar los metodos http creados en el backend de un api, se puede obtener, enviar eliminar y actualizar esto por lo general sirve para diagnosticar que un api funcione correctamente
#######

#######
22. ¿Qué es un status code HTTP?
# .Respuesta 22: En Web, los codigos de estado son las respuestas que da la ejecucion de una petición asi sabemos si fue exitosa o si fallo a que se debe  
#######

#######
23. Nombra y explica brevemente los códigos 200, 400 y 500.
# .Respuesta 23: los codigos 200 por ejemplo es cuando la petición responde bien y se ejecuto correctamente, en postman sale algo como 200: OK , los codigos 400 ya pueden ser que la peticion fallo por diferentes razones 401: no autorizado, 404 no existe o 403: mala peticion (probablmente el json este mal o el metodo no reciba un tipo de dato) y los errores 500 son del lado del servidor, cuando algo en el backend definitivamente no funciona como deberia
#######

#######
24. Diferencia entre GET y POST.
# .Respuesta 24: el get se usa para obtener ya sea todo lo que responda el api o un valor en especifico, post es para enviar datos ambos son metodos hhtp
#######

#######
26. ¿Qué es un header en una petición HTTP?
# .Respuesta 25: el encabezado son esos metadatos que se envian con las peticiones http que acompañan el json de la peticion, dependiendo del metodo en el header se puede definir diferentes caracteristicas
#######


# Parte Teórica – Microservicios (.NET)


#######
24. ¿Qué es un microservicio?
# .Respuesta 24: es un modelo  de arquitectura de software donde se dividen las piezas de software en partes independientes que funcionan conectadas entre si 
#######

#######
25. Diferencia entre arquitectura monolítica y microservicios.
# .Respuesta 25: la arquitectura monolitica esta construido todos los servicios en una sola pieza de software completa, bueno para soluciones pequeñas pero 0 escalable, y microservicios es dividir diferentes  proyectos conectados entre si (pueden ser api) para que sea mas escalable a largo plazo
#######


#######
26. ¿Cómo se comunican normalmente dos microservicios?
# .Respuesta 26: se comunican normalmente por peticiones mediante api
#######

#######
27. ¿Qué es HTTP y para qué se utiliza?
# .Respuesta 27: Es un protocolo de peticiones web donde se comunican y hay un intercambio de mensajes entre varios sistemas
#######


#######
28. ¿Qué es una API REST?
# .Respuesta 28: Un API Rest es una tecnologia que permite conectar diferentes sistemas para que exista una comunicación entre diferentes tecnologias, los metodos HTTP son vitales ya que permiten la comunicacion entre frontend con el backend que a su vez controla tanto la base de datos como la logica de negocio, existen metodos (o peticiones) HTTP como GET (sirve para obtener los datos) POST (Sirve para Enviar datos) DELETE (Borrar datos) PUT (Para actualizar) existen mas metodos sin embargo estos son los escenciales en todo backend 
#######


#######
29. ¿Qué es inyección de dependencias?
# .Respuesta 29: la inyección de dependecias es basicamente indicarle al proyecto de donde va a extraer o consultar las tecnologias que va a usar asi como su versión, esto es utilizado para que al momento de usar un framework o una librearia en el codigo el sistema al momento de compilar pueda conectarse a estas tecnologias
#######

#######
30. ¿Qué es HttpClient y para qué sirve?
# .Respuesta 30: es un servicio que se usa para hacer petificiones http para angular 
#######

#######
31. ¿Qué es un status code HTTP?
# .Respuesta 31: En Web, los codigos de estado son las respuestas que da la ejecucion de una petición asi sabemos si fue exitosa o si fallo a que se debe  
#######

#######
32. ¿Qué significa un error 500?
# .Respuesta 32: Es un error ligado a el servidor interno, cuando sale esto quiere decir que el servicio no funciona del lado del servidor
#######

#######
37. ¿Por qué es importante el versionado de dependencias?
# .Respuesta 33: es importante porque a veces algunas dependecias no son compatibles con otras y cuando se actualizan algunas pueden dejar de ser compatibles y esto puede generar incluso un fallo en el proyecto, en caso de estar en produccion esto puede ser fatal
#######
