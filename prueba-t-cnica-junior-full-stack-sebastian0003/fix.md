# Corrección de Falla

Describe:
- Qué error encontraste
- Por qué ocurría
- Cómo lo solucionaste


# Fix – Comunicación entre Microservicios (OrderService → UserService)

El microservicio OrderService no estaba consumiendo correctamente el UserService o no estaba procesando adecuadamente su respuesta.

Como resultado:
- La información del usuario no se integraba correctamente en la respuesta de la orden
- Se devolvía información en formato incorrecto o incompleto

---

## Causa del problema

Se identificaron los siguientes problemas:

- Uso incorrecto de HttpClient sin configuración adecuada
- Falta de HttpClientFactory o BaseAddress configurado
- Respuesta del UserService tratada como string en lugar de JSON
- Ausencia de deserialización a un objeto (DTO)

---

## Solución aplicada

Se realizaron las siguientes correcciones:

### 1. Configuración de HttpClient

Se configuró correctamente la comunicación entre microservicios usando HttpClientFactory:
