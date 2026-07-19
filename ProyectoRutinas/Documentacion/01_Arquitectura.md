# Arquitectura del Proyecto

## Proyecto

**Nombre:** ProyectoRutinas

**Tipo de aplicación:** ASP.NET MVC (.NET Framework)

**Patrón de arquitectura:** Modelo - Vista - Controlador (MVC)

---

# Objetivo

Definir la arquitectura general del proyecto, la organización de sus componentes y las responsabilidades de cada capa para mantener un desarrollo uniforme entre todos los integrantes del equipo.

---

# Estructura General

ProyectoRutinas
│
├── Controllers
├── Models
├── Views
├── Data
├── Services
├── Content
├── Scripts
├── Documentacion
└── App_Data

---

# Responsabilidad de cada carpeta

## Controllers

Reciben las solicitudes del usuario, procesan la petición y coordinan la comunicación entre las vistas y los servicios.

---

## Models

Representan las entidades del sistema y transportan la información entre las diferentes capas de la aplicación.

---

## Views

Contienen la interfaz gráfica del usuario utilizando Razor (.cshtml).

---

## Data

Administra la conexión con la base de datos.

No contiene lógica de negocio.

No contiene consultas relacionadas con la interfaz.

---

## Services

Contiene toda la lógica de negocio del sistema.

Aquí se realizarán las operaciones de:

- Registrar
- Consultar
- Actualizar
- Eliminar

---

## Content

Contiene los recursos visuales del proyecto.

Ejemplos:

- CSS
- Imágenes
- Iconos

---

## Scripts

Contiene los archivos JavaScript utilizados por las vistas.

---

## Documentacion

Contiene la documentación técnica del proyecto.

---

# Flujo de una petición

Usuario
    │
    ▼
View (.cshtml)
    │
    ▼
Controller
    │
    ▼
Service
    │
    ▼
Data
    │
    ▼
Base de Datos

La respuesta regresa siguiendo el mismo camino en sentido contrario.

---

# Reglas de arquitectura

## Views

- No acceden directamente a la base de datos.
- No contienen lógica de negocio.

---

## Controllers

- Reciben las solicitudes del usuario.
- Llaman a los Services.
- Devuelven las vistas correspondientes.
- No ejecutan consultas SQL.

---

## Services

- Contienen la lógica del negocio.
- Utilizan la capa Data para acceder a la base de datos.
- No generan vistas.

---

## Data

- Administra las conexiones con la base de datos.
- No contiene lógica del negocio.

---

## Models

- Representan entidades del sistema.
- No realizan conexiones a la base de datos.
- No contienen lógica de presentación.

---

# Principios del proyecto

- Una clase debe tener una única responsabilidad.
- Cada carpeta tiene un propósito específico.
- La lógica de negocio pertenece únicamente a la capa Services.
- La conexión con la base de datos pertenece únicamente a la capa Data.
- El proyecto seguirá el patrón MVC durante todo su desarrollo.
