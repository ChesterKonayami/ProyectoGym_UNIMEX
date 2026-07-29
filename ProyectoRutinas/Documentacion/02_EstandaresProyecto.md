# JOSEPH MAURICIO MONDRAGÓN MORENO

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

Todos los archivos `.cs` deberán comenzar con un encabezado que describa:

- Proyecto
- Archivo
- Descripción
- Responsabilidad
- Autor

Los comentarios deberán utilizarse para explicar el propósito del código y facilitar su mantenimiento. No deberán utilizarse para documentar reglas de trabajo del equipo.

---

# Organización del Código

Cada clase deberá tener una única responsabilidad.

No se permitirá mezclar lógica de negocio, acceso a datos o presentación dentro de una misma clase.

---

# Base de Datos

- Toda conexión deberá realizarse desde la carpeta **Data**.
- Las consultas SQL deberán ejecutarse desde **Services** utilizando la conexión proporcionada por **ConexionBD**.
- Los Controllers no deberán ejecutar consultas SQL directamente.
- La estructura oficial de la base de datos será la documentada en **06_BaseDatos.md**.

---

# Vistas

Las vistas únicamente mostrarán información al usuario.

No deberán contener lógica de negocio.

---

# Controladores

Los Controllers recibirán las solicitudes del usuario y coordinarán la comunicación entre las vistas y los servicios.

---

# Services

Contendrán toda la lógica de negocio.

Serán responsables de las operaciones CRUD y del acceso a los datos mediante la clase de conexión.

---

# Git y GitHub

- La rama principal del proyecto será **master**.
- Cada integrante desarrollará sus funcionalidades en su propia rama.
- Los elementos de infraestructura del proyecto podrán desarrollarse y mantenerse directamente en la rama **master**.
- Los cambios realizados en las ramas individuales deberán revisarse antes de integrarse a la rama principal.

---

# Archivos de Infraestructura

Los siguientes archivos forman parte de la infraestructura general del proyecto y no deberán modificarse sin previo acuerdo del equipo:

- ConexionBD.cs
- ProyectoGym.sql
- 06_BaseDatos.md
- README.md

Estos archivos contienen la configuración base del proyecto y cualquier modificación puede afectar el funcionamiento del entorno de desarrollo de todos los integrantes.

Si algún integrante requiere una configuración diferente de MySQL para su equipo, deberá realizar dicho cambio únicamente en su entorno local y no subirlo al repositorio sin la aprobación del equipo.

---
## Configuración de la Conexión a la Base de Datos

El archivo **ConexionBD.cs** forma parte de la infraestructura principal del proyecto.

Este archivo contendrá la configuración oficial de conexión a la base de datos utilizada por todo el equipo durante el desarrollo.

La configuración oficial será:

- Servidor: 127.0.0.1
- Base de datos: proyectogym
- Usuario: root
- Contraseña: (vacía)

Con el objetivo de mantener un entorno de desarrollo uniforme y evitar conflictos entre ramas, **ConexionBD.cs no deberá modificarse en las ramas individuales**.

Si algún integrante requiere utilizar una configuración diferente en su equipo (por ejemplo, un usuario distinto o una contraseña para MySQL), deberá comunicarlo al responsable del proyecto antes de realizar cualquier modificación y dicho cambio no deberá integrarse a la rama **master** sin la aprobación del equipo.

Esta política busca garantizar que todos los integrantes trabajen sobre la misma configuración de desarrollo y evitar errores derivados de diferencias en el entorno local.

---

# Objetivo del Equipo

Mantener un proyecto organizado, escalable y fácil de comprender para todos los integrantes durante todo el ciclo de desarrollo.
