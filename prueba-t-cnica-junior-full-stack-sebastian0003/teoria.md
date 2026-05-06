# Parte Teórica

## .NET
**1. ¿Qué es una API REST y qué métodos HTTP conoces?**   
un API RESET Es un contrato de conexion entre dos puntos que intercambian informacion y este se puede usar con el protocolo HTTP que permite usar metodos basicos CRUD
GET: me permite solicitar informacion
POST: me permite postear o enviar datos
PUT: me permite actualizar informacion
DELETE: para eliminar informacion

**2. ¿Qué diferencia hay entre un DTO y un modelo de dominio?**   
el modelo de dominio es la representacion logica, 

uno me dice como pensar el sistema y el modelo de dominio me dice como se ve el sistema

**3. ¿Qué es la inyección de dependencias y para qué se utiliza?**   
es un metodo para que el objeto tome dependencias desde afuera sin necesidad de crear depenciencias desde el objeto.

**4. ¿Para qué sirve el archivo appsettings.json?**   
Me permite guardar parametros dentro de este archivo para el funcionamiento de mi sistema, teniendi encuenta que pueden variar segun las necesidades de cada proyecto.

**6. Diferencia entre IEnumerable y List.**   
IEnumerable es una interfaz  y list es una clase concreta que ya tiene su estructura de datos

## SQL Server
**6. ¿Qué es una clave primaria?**   
Clave primaria es un dato relevante que debe ser unico funciona como identificador de cada registro   

**7. Diferencia entre INNER JOIN y LEFT JOIN.**   
la diferencia esta en el metodo de coincidencia que tiene cada uno, mientras uno incluye coincidencias el otro no trae coincidencias   

**8. ¿Para qué sirve un índice en una base de datos?**   
para realizar busquedas de manera efectivas, nos ayuda a realizar un proceso mas simple en las busquedas   

**9. ¿Qué significa normalizar una base de datos?**   
la normalizacion de bases de datos funciona para evitar redundancias o duplicidades, nos ayuda a tener un orden en cada table de la base de datos   

**10. Escribe una consulta SQL que obtenga los usuarios activos de una tabla Users.**   
SELECT * FROM Users where active=true;

## Git / GitHub
**11. ¿Qué es Git y para qué se utiliza?**   
Es un sistema de control de versiones, es usado para saber que cambios tiene el codigo fuente y tambien permite que se trabaje e simulteneo en el mismo proyecto    

**12. Diferencia entre commit, push y pull.**   
Commit: guarda cambios de manera local sobre el repositorio   
Push: permite subir los commit a repositorios   
Pull: permite la descarga de los cambios del repositiorio remoto    

**13. ¿Qué es un branch?**   
permote desarrollar nuevas funciones, corregir errores evitando afectar el codigo main hasta finalizar el trabajo   

**14. ¿Para qué sirve un Pull Request?**   
intercambio de rama, permite que otros participantes del proyecto puedan verificar el codigo   

**15. ¿Qué problema resuelve GitHub Classroom?**   
meroja la distribucion de tareas y la gestion que hay dentro del repositorio.   

## Angular
**16. ¿Qué es Angular?**   
Es un framework creado por google para el desarrollo de aplicaciones web de una sola pagina   

**17. Diferencia entre component y service.**   
Componet: Controla la parte de la vista y su logica   
Service: contiene la logica   

**18. ¿Para qué sirve ngOnInit?**   
es un metodo que se ejecuta de manera automatica cuando el componente se inicia, es para carfar datos iniciales desde un servicio   

**19. ¿Qué es data binding?**   
se trata de la comucicacion entre el typescript y el html.   

**20. Diferencia entre ngIf y ngFor**   
ngIf: muestra y oculta elemente   
ngFor: repite un elemente de la lista   

## Postman / HTTP
**21. ¿Para qué se utiliza Postman?**   
Se usa para el envio de peticiones a un servidor api   

**22. ¿Qué es un status code HTTP?**   
es un codigo que me devuleve el servidor que me indica si la peticion fue exitosa   

**23. Nombra y explica brevemente los códigos 200, 400 y 500.**   
200: ok   
400: se envio algo mal, faltan datos o peticion incorrecta   
500: el servidor no procesa bien la peticion   

**24. Diferencia entre GET y POST.**   
GET: me permite solicitar informacion   
POST: me permite postear o enviar datos   

**25. ¿Qué es un header en una petición HTTP?**   
es informacion que se adiciona a la peticion, JSON   

# Parte Teórica – Microservicios (.NET)
**26. ¿Qué es un microservicio?**   
es cuando una aplicacion se divide en varios servidios pequeños que se comunican entre si   

**27. Diferencia entre arquitectura monolítica y microservicios.**   
Monolitica: todo esta en un solo lugar   
Microservicio: cada funcion es independiente   

**28. ¿Cómo se comunican normalmente dos microservicios?**   
se comunican por peticiones HTTP API Reset    

**29. ¿Qué es HTTP y para qué se utiliza?**   
es el protocolo que permite usar metodos basicos CRUD para el intercambio de informacion   

**30. ¿Qué es una API REST?**   
un API RESET Es un contrato de conexion entre dos puntos que intercambian informacion   

**31. ¿Qué es inyección de dependencias?**   
es un metodo para que el objeto tome dependencias desde afuera sin necesidad de crear depenciencias desde el objeto.   

**32. ¿Qué es HttpClient y para qué sirve?**   
es una clase que se usa para enviar peticiones GET-POST hacia otros servicios o APIS externas   

**33. ¿Qué es un status code HTTP?**
es un codigo que me devuleve el servidor que me indica si la peticion fue exitosa   

**34. ¿Qué significa un error 500?**   
significa que la peticion no se pudo procesar en el servidor   

**35. ¿Por qué es importante el versionado de dependencias?**   
sirve para las versiones de las librerias compatibles y evitar las actualizaciones de las mismas.   
