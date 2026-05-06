# Parte Teórica

## .NET
1. ¿Qué es una API REST y qué métodos HTTP conoces?
Es un manera de comunicación entre dos sistemas
GET: obtener 
POST: crear
UPDATE: actualizar
DELETE: eliminar
PATCH: actualizar (solo una parte)
2. ¿Qué diferencia hay entre un DTO y un modelo de dominio?
DTO Transporta datos sin lógica 
Dominio son las reglas y lógica de negocio
3. ¿Qué es la inyección de dependencias y para qué se utiliza?
Es una clase en donde no se crean las dependencias de forma propia, las recibe de afuera.
4. ¿Para qué sirve el archivo appsettings.json?
5. Diferencia entre IEnumerable y List.
List: es una lista específica y modificable
Es un archivo donde se guarda la configuración de la aplicación
IEnumerable: sirve para devolver datos

## SQL Server
6. ¿Qué es una clave primaria?
Sirve para identificar de forma única cada registro de una tabla.
7. Diferencia entre INNER JOIN y LEFT JOIN.
Inner join sirve para traer la data de solo las coincidencias es decir los que tengan relación con ambas tablas.
Ejm: select u.nombre, p.producto from Usuarios u inner join pedidos p on u.idUsuario;
Left join sirve para traer la data de la izquierda más las coincidencias.
Ejm: select u.nombre, p.producto from Usuarios u left join pedidos p on u.idUsuario;
8. ¿Para qué sirve un índice en una base de datos?
Sirve para buscar datos de forma más rápida, acelera consultas, mejoa filtros, ayuda a optimizar.
9. ¿Qué significa normalizar una base de datos?
Es organizar tablas, sirve para tener mejor consistencia.
10. Escribe una consulta SQL que obtenga los usuarios activos de una tabla Users.
SELECT * FROM Users where estado='activo';

## Git / GitHub
11. ¿Qué es Git y para qué se utiliza? 
Sirve para el control de versiones de lo que se esta realizando.
12. Diferencia entre commit, push y pull.
Commit: Confirmar cambios que se estan realizando y agregar el comentario de lo que se esta subiendo.
Push: Enviar los cambios, es decir subirlos
Pull: Actualizar el entorno (rama) donde se este trabajando.
13. ¿Qué es un branch?
Es la rama donde se realizará el desarrollo, se crea apartir de la rama principal (main/develop/etc)
14. ¿Para qué sirve un Pull Request?
Crea el archivos con los cambios que se realizaron y se subiran al proyecto, permite realizar revisión de código.
15. ¿Qué problema resuelve GitHub Classroom?
Gestiona, evalua y organiza tareas de forma automatizada.


## Angular
16. ¿Qué es Angular?
Es un framework de frontend que usa para aplicaciones web.
17. Diferencia entre component y service.
component es lo que se ve (front)
service la lógica (backend, apis)
18. ¿Para qué sirve ngOnInit?
Se puede tomar como ciclo de vida de un componente. Sirve para llamar apis, cargar data, entre otros.
19. ¿Qué es data binding?
Una forma de realizar conexión entre el HTML y typescript es decir entre la vista y la lógica.
20. Diferencia entre *ngIf y *ngFor.
Sirve para controlar lo que se renderiza en el html. 
ngIf es un condicional ngFor sirve para iterar sobre listas.

## Postman / HTTP
21. ¿Para qué se utiliza Postman?
Postman se utiliza para realizar pruebas manuales, consumiendo apis.
22. ¿Qué es un status code HTTP?
Son los números que devuelve el api para indicar que pasó con la petición.
23. Nombra y explica brevemente los códigos 200, 400 y 500.
200: OK Código para respuestas exitosas
400: Bad request, errores al momento de la ejecución
500: Internal Server Error Errores en el servidor
24. Diferencia entre GET y POST.
GET: Obtener/traer información
POST: Crear 
25. ¿Qué es un header en una petición HTTP?
Son metadatos, es decir información adicional que se envía en una petición.

# Parte Teórica – Microservicios (.NET)
26. ¿Qué es un microservicio?
Es una forma de dividir pequeños servicios independientes y no tener todo dentro de uno solo.
27. Diferencia entre arquitectura monolítica y microservicios.
Monolitíca: se tiene todo dentro del mismo
Microservicios: se dividen entre servicios independientes
28. ¿Cómo se comunican normalmente dos microservicios?
Puede ser de forma síncrona usando http como apis rest, y de forma asíncrona usando eventos o colas
29. ¿Qué es HTTP y para qué se utiliza?
Es lo que permite la comunicación entre el navegador (front) con el servidor (back)
30. ¿Qué es una API REST?
Es una manera de comunición entre dos sistemas como si fuera un puente
31. ¿Qué es inyección de dependencias?
Es una clase en donde no se crean las dependencias de forma propia, las recibe de afuera.
32. ¿Qué es HttpClient y para qué sirve?
Es una forma que se usa para hacer peticiones http a otras apis.
33. ¿Qué es un status code HTTP?
Son los números que devuelve el api para indicar que pasó con la petición.
34. ¿Qué significa un error 500?
Errores en el servidor Internal Server Error
35. ¿Por qué es importante el versionado de dependencias?
Es importante porque garantiza compatibilidad evitando que haya conflictos entre librerías lo que permite estabilidad.
