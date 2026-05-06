# Actualización de Dependencias

Describe:

- Paquete actualizado
- Versión anterior
- Versión nueva
- Si hubo cambios necesarios

## Paquete agregado: Swashbuckle.AspNetCore

- **Versión anterior:** No estaba instalado
- **Versión nueva:** 10.1.7
- **Proyecto:** order-service/OrderService.Api

## ¿Por qué se agregó?

El OrderService no tenía documentación del API. Se agregó Swashbuckle
para generar automáticamente la documentación con Swagger UI, lo que
facilita probar y entender los endpoints sin necesidad de Postman.

## Cambios realizados

Se agregaron dos líneas en Program.cs para habilitar Swagger:

```
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
```

Y dos líneas para servir la interfaz visual:

```
app.UseSwagger();
app.UseSwaggerUI();
```

## Verificación

La aplicación sigue compilando y corriendo correctamente.
Swagger UI disponible en: http://localhost:5000/swagger
