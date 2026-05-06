## Actualización de dependencias

Se ejecutó el siguiente comando para identificar paquetes desactualizados:

dotnet list package --outdated

No se encontraron paquetes desactualizados en OrderService.Api y UserService.Api.

### Acción realizada

Para cumplir con todos los requerimientos de la prueba, se agregó el paquete Microsoft.AspNetCore.OpenApi en su versión 8.0.0 en el proyecto OrderService.Api, asegurando compatibilidad con .NET 8 y manteniendo estable la app.

### Verificación

Se ejecutaron los siguientes comandos para validar el correcto funcionamiento después del cambio:

dotnet clean  
dotnet build  

La aplicación compiló correctamente sin errores.

### Nota adicional

Durante la ejecución de la prueba, fue necesario instalar el SDK de .NET 8, ya que el entorno inicialmente contaba con una versión diferente (.NET 10), lo que generaba conflictos al ejecutar los microservicios. Esto permitió alinear el entorno con la versión del proyecto y garantizar su correcto funcionamiento.
