# Prueba Técnica – Junior Backend (.NET Microservicios)

Esta prueba simula situaciones reales del día a día trabajando con
**microservicios en .NET**.

Se evaluará:
- Comunicación entre microservicios
- Lectura de código existente
- Identificación y corrección de errores
- Mantenimiento (actualización de dependencias)
- Fundamentos teóricos

---

## Duración total
**5 horas**

---

## Parte 1 – Teoría

Responde las preguntas en el archivo:

`teoria.md`

---

## Parte 2 – Comunicación entre Microservicios

Existen dos microservicios:

### UserService
Expone información de usuarios.

### OrderService
Debe consumir UserService, pero **actualmente NO lo hace correctamente**.

Tu tarea:
- Conectar OrderService con UserService
- Consumir el endpoint de usuarios
- Retornar una respuesta compuesta

---

## Parte 3 – Debug / Fix

Uno de los microservicios contiene un **error intencional** que provoca
fallas en tiempo de ejecución.

Tu tarea:
- Identificar el error
- Corregirlo
- Explicar qué pasaba y cómo lo solucionaste en `fix.md`

---

## Parte 4 – Actualización de Dependencias

Backend:
- Identifica paquetes NuGet desactualizados
- Actualiza al menos uno
- La aplicación debe seguir compilando

Documenta el cambio en `updates.md`

---

## Reglas importantes

✅ Puedes usar documentación oficial  
✅ Puedes usar StackOverflow  
❌ No usar asistentes de IA  
❌ No copiar proyectos completos  

---

## Reglas de commits

- Mínimo **3 commits**
- Commits claros y progresivos

| Tipo         | Cuando usarlo                                           | Ejemplo                                                      |
|--------------|---------------------------------------------------------|--------------------------------------------------------------|
| `feat`       | Nueva funcionalidad para el usuario                     | `feat(login): agregar autenticacion con Azure AD`            |
| `fix`        | Correccion de un bug                                    | `fix(dashboard): corregir calculo de totales`                |
| `docs`       | Cambios solo en documentacion                           | `docs(api): actualizar documentacion de endpoints`           |
| `style`      | Formato, punto y coma, espacios (no cambia logica)      | `style(app): aplicar formato consistente con Prettier`       |
| `refactor`   | Refactorizacion que no agrega feature ni corrige bug    | `refactor(auth): simplificar logica de validacion de token`  |
| `test`       | Agregar o modificar pruebas                             | `test(login): agregar pruebas para validacion de email`      |
| `chore`      | Tareas de mantenimiento, build, dependencias            | `chore(deps): actualizar Angular de 21.0 a 21.1`            |
| `perf`       | Mejora de rendimiento                                   | `perf(queries): optimizar consulta de reportes mensuales`    |
| `ci`         | Cambios en configuracion de CI/CD                       | `ci(pipeline): agregar step de analisis de codigo`           |
| `build`      | Cambios en el sistema de build o dependencias externas  | `build(docker): actualizar imagen base a .NET 8.0.2`        |
| `revert`     | Revertir un commit anterior                             | `revert: revert feat(login) - commit a1b2c3d` 

### Ejemplos Buenos Commits
```bash
# Feature nueva
git commit -m "feat(login): agregar formulario de inicio de sesion con validacion reactiva"

# Feature con cuerpo descriptivo
git commit -m "feat(reports): implementar exportacion a Excel" -m "Se utiliza la libreria EPPlus para generar archivos .xlsx con formato personalizado. Se incluyen filtros por fecha y categoria. Relacionado con HU-001."

# Bug fix
git commit -m "fix(dashboard): corregir error de renderizado en grafico de barras"

# Refactorizacion
git commit -m "refactor(auth): extraer logica de JWT a servicio independiente"

# Test
git commit -m "test(users): agregar pruebas unitarias para servicio de registro"

# Dependencias
git commit -m "chore(deps): actualizar Angular CLI a version 21.1.0"

# Documentacion
git commit -m "docs(api): documentar endpoint de creacion de usuarios"

# Breaking change (cambio que rompe compatibilidad)
git commit -m "feat(api)!: cambiar estructura de respuesta de autenticacion" -m "BREAKING CHANGE: el campo 'token' ahora se devuelve dentro de un objeto 'auth'. Los clientes deben actualizar el parseo de la respuesta."

# CI/CD
git commit -m "ci(pipeline): agregar analisis de cobertura de codigo"
```

### Ejemplos Malos Commits
```bash
# Sin tipo
git commit -m "login actualizado"

# Demasiado vago
git commit -m "fix: arreglar cosas"
git commit -m "feat: cambios"
git commit -m "update"

# En pasado
git commit -m "feat(login): se agrego el formulario"

# Demasiado largo en el titulo
git commit -m "feat(login): agregar el formulario de inicio de sesion con validacion reactiva de campos email y password incluyendo mensajes de error personalizados y estilos responsive"

# Con punto final
git commit -m "feat(login): agregar formulario."

# Primera letra mayuscula despues de los dos puntos
git commit -m "feat(login): Agregar formulario"

# Multiples cambios no relacionados en un solo commit
git commit -m "feat(login): agregar login y fix dashboard y actualizar deps"

# Mensajes sin sentido
git commit -m "wip"
git commit -m "asdf"
git commit -m "temp"
git commit -m "save"
```


## Checklist final

- [ ] Microservicios corren correctamente
- [ ] Comunicación entre servicios funciona
- [ ] Bug corregido
- [ ] Paquete actualizado
- [ ] teoria.md completo
- [ ] fix.md completo
- [ ] updates.md completo

¡Éxitos!
