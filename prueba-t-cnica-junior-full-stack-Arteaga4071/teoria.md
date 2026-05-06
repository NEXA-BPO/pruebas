# Parte Teórica

## .NET
1. ¿Qué es una API REST y qué métodos HTTP conoces? 
R: Una API es una especie de puente que se usa para hacer que dos aplicaciones se comuniquen entre si y compartan datos o información y un metodo que conozco puede ser el Get o Post

2. ¿Qué diferencia hay entre un DTO y un modelo de dominio? 
R: Dto se usa para llevar datos entre capas o sistemas y no tiene mucha logica para un negocio real, a diferencia de modelo de dominio que si tiene esta logica, teniendo reglas, no como DTO que no las posee.

3. ¿Qué es la inyección de dependencias y para qué se utiliza? 
R: Inyección de dependencias o DI, es un patrón de diseño que promueve el desacople de componentes, así cada clase tendrá sus dependencias de manera externa y no se tendrán que crear manualmente.

4. ¿Para qué sirve el archivo appsettings.json? 
R: este es para guardar la configuración de la app, como conexiones a la base de datos y la conexión en general.

5. Diferencia entre IEnumerable y List.
R: La diferencia es que IEnumerable se usa para leer datos y list si permite trabajar directamente con esos datos, IEnumerable no permite agregar ni modificar, pero List si lo permite.

## SQL Server
6. ¿Qué es una clave primaria? 
R: Es un campo o conjunto de campos en una tabla de base de datos que se usa para identificar de forma única cada registro

7. Diferencia entre INNER JOIN y LEFT JOIN. 
R: Inner Join devuelve solo los registros que tienen coincidencias en ambas tablas y Left Join devuelve todos los registros de la tabla de la primera tabla a la izquierda y las coincidencias a la derecha.

8. ¿Para qué sirve un índice en una base de datos? 
R: los indices sirven para encontrar datos con más facilidad en una base de datos.  

9. ¿Qué significa normalizar una base de datos? 
R: Normalizar sirve para organizar los datos de las tablas de forma estructurada para evitar duplicados, también hace la base de datos mas fácil de analizar y eficiente 

10. Escribe una consulta SQL que obtenga los usuarios activos de una tabla Users. 
R: Select * From Users Where estado = "activo";

## Git / GitHub
11. ¿Qué es Git y para qué se utiliza? 
R: Git se usa normalmente para el control de versiones, así mismo git tiene sus comandos para poder clonar un repositorio en Visual Studio Code por ejemplo y así mismo poder trabajar en el, también permite generar commits que son los cambios realizados al codigo, son verificables desde GitHub, esto ayuda a la seguridad del codigo y al versionamiento del mismo.

12. Diferencia entre commit, push y pull. 
R: el commit sirve para guardar los cambios en un repositorio de tu PC o local, el push envia los cambios a repositorios en github y el pull trae los cambios del repositorio de github al pc que estas usando.

13. ¿Qué es un branch?
R: Es como un proyecto fantasma por así decirlo, este permite trabajar con el proyecto pero sin afectar el codigo principal, es muy util para trabajar en equipo en diferentes tareas al tiempo.

14. ¿Para qué sirve un Pull Request? 
R: Pull Request es una solicitud para integrar cambios de una rama a otra, permitiendo la revisión del código, y si está correcto integrarlo al proyecto principal.

15. ¿Qué problema resuelve GitHub Classroom? 
R: Este permite a los profesores gestionar tareas usando repositorios Git, facilitando la entrega, seguimiento y evaluación del trabajo de los estudiantes. 

## Angular
16. ¿Qué es Angular? 
R: Angular es un framework desarrolado por Google que sirve para desarrollar proyectos modernos usando componentes reutizables y el lenguaje base TypeScript, este tiene un ligero parecido a JavaScript, pero como su nombre indica, el lenguaje de angular, TypeScript tiende a ser mas tipado y complejo. 

17. Diferencia entre component y service. 
R: Component es todo lo que el usuario ve, es decir, la interfaz, y service es todo lo que funciona, maneja la logica y los datos como el consumo de la API.

18. ¿Para qué sirve ngOnInit?
R: NgOnInit es un método del ciclo de vida que se ejecuta al iniciar un componente y se usa para cargar datos o ejecutar lógica inicial.

19. ¿Qué es data binding? 
R: Data binding es una forma de conectar los datos con la interfaz sin problemas.

20. Diferencia entre *ngIf y *ngFor.
R: *ngIf se usa para mostrar y ocultar elementos según una condición, mientras que *ngFor se utiliza para iterar sobre listas y renderizar elementos de una mejor forma.

## Postman / HTTP
21. ¿Para qué se utiliza Postman? 
R: Postman se utiliza para probar y analizar APIs, envia peticiones al servidor para verificar que es lo que devuelve y así no es necesaria una interfaz o vista. 

22. ¿Qué es un status code HTTP?
R: status code HTTP es un código numérico que el servidor devuelve para indicar el resultado de una solicitud.

23. Nombra y explica brevemente los códigos 200, 400 y 500.
R: El codigo 200 indica que una solicitud es exitosa, el 400 indica un error del cliente y 500 un error de servidor.

24. Diferencia entre GET y POST. 
R: Get es para obtener y ver datos y post es para enviar o crear

25. ¿Qué es un header en una petición HTTP?
R: Un header es información adicional que se envía en una petición HTTP para ayudar al servidor a entender y procesar la solicitud.

# Parte Teórica – Microservicios (.NET)
26. ¿Qué es un microservicio? 
R: Es una manera de crear o hacer aplicaciones donde el sistema se divide en pequeños servicios que funcionan de manera independiente y cada uno tiene una función en especifico.

27. Diferencia entre arquitectura monolítica y microservicios.
R: La arquitectura monolítica es una aplicación unificada, mientras que los microservicios dividen la aplicación en pequeños servicios independientes que se comunican entre sí.

28. ¿Cómo se comunican normalmente dos microservicios?
R: Los microservicios se comunican principalmente mediante APIs o mediante mensajería usando eventos, dependiendo de si se requiere respuesta inmediata o no.

29. ¿Qué es HTTP y para qué se utiliza?
R: HTTP es el protocolo que permite la comunicación entre cliente y servidor en internet.

30. ¿Qué es una API REST? 
R: Es un puente de conexión que sirve para hacer que dos aplicaciones se comuniquen entre si e intercambien información.

31. ¿Qué es inyección de dependencias? 
R: Inyección de dependencias o DI, es un patrón de diseño que promueve el desacople de componentes, así cada clase tendrá sus dependencias de manera externa y no se tendrán que crear manualmente.

32. ¿Qué es HttpClient y para qué sirve? 
R: HttpClient es un servicio que se usa para enviar y recibir datos desde APIs mediante peticiones HTTP en Angular.

33. ¿Qué significa un error 500? 
R: error en el backend, es decir, error en el servidor al procesar alguna solicitud.

34. ¿Por qué es importante el versionado de dependencias? 
R: El versionado de dependencias es importante porque garantiza que un proyecto use versiones específicas de librerías, evitando conflictos, errores y asegurando que el sistema sea estable.
