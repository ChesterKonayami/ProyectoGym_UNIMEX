# Estándares del Proyecto

## Objetivo

Definir las convenciones de desarrollo que deberán seguir todos los integrantes del equipo para mantener un código uniforme, organizado y fácil de mantener.

---

# Convenciones Generales

- Todo el proyecto seguirá el patrón de arquitectura MVC.
- Se respetará la estructura de carpetas definida en la documentación.
- Cada archivo deberá tener una única responsabilidad.
- Todo nuevo archivo deberá ubicarse en la carpeta correspondiente según su función.

---

# Convención de Idioma

## Framework

Los nombres propios del framework ASP.NET MVC permanecerán en inglés.

Ejemplos:

- Controllers
- Models
- Views
- Scripts
- Content
- Shared
- HomeController
- AccountController

---

## Proyecto

Los elementos propios del dominio del proyecto estarán en español.

Ejemplos:

- Usuario
- Registro
- Perfil
- Rutina
- ConexionBD
- UsuarioService

---

# Convención de Nombres

## Carpetas

Utilizar PascalCase.

Ejemplos:

- Controllers
- Models
- Services
- Data
- Documentacion

---

## Clases

Utilizar PascalCase.

Ejemplos:

- Usuario
- UsuarioService
- ConexionBD
- HomeController
- AccountController

---

## Métodos

Utilizar PascalCase.

Ejemplos:

- RegistrarUsuario()
- ActualizarUsuario()
- EliminarUsuario()
- IniciarSesion()

---

## Propiedades

Utilizar PascalCase.

Ejemplos:

- IdUsuario
- Nombre
- Correo
- Password

---

## Variables Locales

Utilizar camelCase.

Ejemplos:

- usuario
- correo
- conexion
- resultado

---

# Comentarios

Todos los archivos .cs deberán comenzar con un encabezado que describa:

- Proyecto
- Archivo
- Descripción
- Responsabilidad
- Autor

---

# Organización del Código

Cada clase deberá tener una única responsabilidad.

No se permitirá mezclar lógica de negocio, acceso a datos o presentación dentro de una misma clase.

---

# Base de Datos

- Toda conexión deberá realizarse desde la carpeta Data.
- Las consultas deberán ejecutarse desde Services utilizando la conexión proporcionada por Data.
- Los Controllers no deberán ejecutar consultas SQL.

---

# Vistas

Las vistas únicamente mostrarán información al usuario.

No deberán contener lógica de negocio.

---

# Controladores

Los Controllers recibirán las solicitudes del usuario y coordinarán la comunicación entre las vistas y los servicios.

---

# Services

Contendrán toda la lógica del negocio.

Serán responsables de las operaciones CRUD.

---

# Git y GitHub

- Cada integrante trabajará en su propia rama.
- La rama principal será "master".
- No se trabajará directamente sobre la rama principal.
- Todo cambio deberá integrarse mediante revisión antes de fusionarse con la rama principal.

---

# Objetivo del Equipo

Mantener un proyecto organizado, escalable y fácil de comprender para todos los integrantes durante todo el ciclo de desarrollo.
