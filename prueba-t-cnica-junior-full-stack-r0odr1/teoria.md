# Parte Teórica

## .NET
1. ¿Qué es una API REST y qué métodos HTTP conoces?
  - Es una interfaz de programacion que se usa el protocolo HTTP para comunicar sistemas, como metodos GET, POST, PUT, y DELETE.
2. ¿Qué diferencia hay entre un DTO y un modelo de dominio?
  - Un DTO solo transporta datos especificos para la vista o API, el dominio representa la entidad real en la base de datos con toda la logica
3. ¿Qué es la inyección de dependencias y para qué se utiliza?
  -  Es un patron de diseno donde un objeto recibe sus dependecias de afuera en lugar de crearlas el mismo. Sirve para desacoplar el codigo y facilitar pruebas
4. ¿Para qué sirve el archivo appsettings.json?
  - Es el archivo de configuracion donde se guardan credenciales, cadenas de conexion a base de datos y variables de entorno
5. Diferencia entre IEnumerable y List.
  - IEnumrable es de solo lectura y permite iterar sobre una coleccion, List permite modificar la coleccion y tiene acceso por indice

## SQL Server
6. ¿Qué es una clave primaria?
  - Es un campo unico, no se repite e identifica que cada registro en una tabla, tambien no permite valores nulos.
7. Diferencia entre INNER JOIN y LEFT JOIN.
  - Inner join devuelve filas con coincidencias en ambas tablas, Left Join devuelve todas las filas de la tabla izquierda y las coincidencias de la derecha, si no hay pone NULL.
8. ¿Para qué sirve un índice en una base de datos?
  - Sirve para acelerar la velocidad de las consultas de busqueda.
9. ¿Qué significa normalizar una base de datos?
  - Es como organizar los datos de una base de datos, evita redundancia, protegiendo identidad de datos.
10. Escribe una consulta SQL que obtenga los usuarios activos de una tabla Users.
  - SELECT FROM * Users Where IsActive = 1;

## Git / GitHub
11. ¿Qué es Git y para qué se utiliza?
  - Es un sistema de control de versiones distribuido ara rastrear cambios en el codigo
12. Diferencia entre commit, push y pull.
  - Commit guarda cambios localmente, push sube esos cambios al servidor remoto y pull descarga y fusiona los cambios del servidor al local
13. ¿Qué es un branch?
  - Una rama o linea de desarrollo separada que permite trabajar en funciones nuevas sin afectar el codigo principal.
14. ¿Para qué sirve un Pull Request?
  - Sirve para fusionar los cambios de una rama a otra, permitiendo revision de codigo antes de integrar
15. ¿Qué problema resuelve GitHub Classroom?
  - Facilita la gestion de tareas de programacion, creando repositorios automaticos y permite la correccion centralizada

## Angular
16. ¿Qué es Angular?
  - Framework de desarrollo, creado por goole y sirve para crear aplicaciones web.
17. Diferencia entre component y service.
  - Un componente maneja la vista y la logica del UI, un servicio maneja logica de negocio y el acceso a datos como las APIs, para ser compartido entre componentes
18. ¿Para qué sirve ngOnInit?
  - Es un hook del ciclo de vida, el cual se ejecuta una vez que el componente ha sido iniciado.
29. ¿Qué es data binding?
  - Es la comunicacion autonoma entre el componnete y la vista
20. Diferencia entre *ngIf y *ngFor.
  - ngIf es una directiva condicional donde puede mostrar u ocultar algun elemento, ngFor es un bucle para repetir un elemento por cada item de una lista

## Postman / HTTP
21. ¿Para qué se utiliza Postman?
  - Herramienta para probar, documentar y consultar APIs.
22. ¿Qué es un status code HTTP?
  - Es un numero que indica el resultado de una peticion, si fue exitosa o un error entre otras.
23. Nombra y explica brevemente los códigos 200, 400 y 500.
  - 200 es una peticion exitosa - 400 es una peticion bad request, es decir datos mal enviados - 500 peticion error del servidor
24. Diferencia entre GET y POST.
  - El metodo GET envia datos a traves de la url, POST enia datos en el cuerpo de la peticion.
25. ¿Qué es un header en una petición HTTP?
  - son metadatos enviados en la peticion, pueden ser tokens de autenticacion

# Parte Teórica – Microservicios (.NET)
26. ¿Qué es un microservicio?
  - Es una arquitectura donde una aplicacion se divide en servicios pequenos, independientes y autonomos los cuales se comunican entre si. Cada uno se enfoca en una unica funcionalidad de negocio.
27. Diferencia entre arquitectura monolítica y microservicios.
  - La Monilitica es que todo el codigo esta en una sola unidad, si una parte falla, suele afectar a todo el sistema, el cual es dificil de escalar por partes
  - La de Microservicios es que cada funcion es un servicio separado, el cual permite escalar solo lo necesario, usar diferentes tecnologias y facilita el despliegue independiente
28. ¿Cómo se comunican normalmente dos microservicios?
  - hay dos formas, sincronica, usando HTTP, REST, los cuales esperan respuesta y asincrona, mediante mensajes como Azure o kafka
29. ¿Qué es HTTP y para qué se utiliza?
  - Es un protocolo de transferencia de hipertexto, se utiliza para la comunicacion y el intercambio de datos en la web entre un cliente y un servidor
30. ¿Qué es una API REST?
  - Es un estilo de arquitectura que utiliza el protocolo HTTP para permitir la comunicacion entre sistemas, basandose en recursos como las urls y metodos estandar como GET, POST.
31. ¿Qué es inyección de dependencias?
  - Es un patron que permite que una clase reciba las herramientas que necesita de un tercero en lugar de crearlas ella misma, mejora la mantenibilidad y permite hacer facil pruebas unitarias
32. ¿Qué es HttpClient y para qué sirve?
  - Es una clase que proporciona una forma de enviar peticiones HTTP y recibir respuestas de recursos identificados por una url
33. ¿Qué es un status code HTTP?
  - Es un codigo numerico enviado por el servidor que indica si una peticion se completo con exito o hubo un erros
34. ¿Qué significa un error 500?
  - Indica un error en el servidor
35. ¿Por qué es importante el versionado de dependencias?
  - Es importante porque garantiza la estabilidad del proyecto, evita que actualizaciones automaticas de librerias externas rompan el codgio existente por cambios que sean incompatibles
