# Distribución del Trabajo

## Objetivo

Definir la organización del equipo de desarrollo, asignando responsabilidades, módulos de trabajo y ramas de Git para mantener un desarrollo ordenado y colaborativo.

---

# Integrantes del Equipo

| Integrante   |         Rama Git | Responsabilidad |   Estado  |
|--------------|------------------|-----------------|-----------|
| Integrante 1 | feature/home     |       Pendiente | Pendiente |
| Integrante 2 | feature/account  |       Pendiente | Pendiente |
| Integrante 3 | feature/database |       Pendiente | Pendiente |
| Integrante 4 | feature/profile  |       Pendiente | Pendiente |

---

# Organización del Proyecto

El desarrollo del proyecto se realizará utilizando Git y GitHub.

Cada integrante trabajará únicamente sobre su propia rama.

Los cambios serán integrados posteriormente a la rama principal.

---

# Estructura de Ramas

|       Rama       |                             Descripción                              |
|------------------|----------------------------------------------------------------------|
| master             | Rama principal del proyecto. Contiene únicamente versiones estables. |
| feature/home     | Desarrollo de la página principal y navegación pública.              |
| feature/account  | Desarrollo del registro, login y autenticación.                      |
| feature/database | Desarrollo de la conexión con la base de datos, modelos y servicios. |
| feature/profile  | Desarrollo del perfil del usuario y operaciones CRUD.                |

---

# Responsabilidades por Módulo

## Home

Responsable de desarrollar:

- Página principal.
- Navegación pública.
- Vista de la rutina de ejemplo.

---

## Account

Responsable de desarrollar:

- Registro.
- Login.
- Validaciones de acceso.

---

## Database

Responsable de desarrollar:

- Conexión con MySQL.
- Modelo Usuario.
- Servicios.
- Operaciones de acceso a datos.

---

## Profile

Responsable de desarrollar:

- Consulta de datos del usuario.
- Actualización del perfil.
- Eliminación de la cuenta.

---

# Reglas de Colaboración

- Cada integrante trabajará únicamente sobre su rama asignada.
- No se realizarán cambios directamente sobre la rama **master**.
- Antes de realizar un merge, el código deberá compilar correctamente.
- Los conflictos deberán resolverse antes de integrar los cambios.
- Todo cambio importante deberá registrarse en **04_HistorialCambios.md**.

---

# Flujo de Trabajo

master

│

├── feature/home

├── feature/account

├── feature/database

└── feature/profile

Cada integrante desarrollará su módulo de forma independiente.

Al finalizar una funcionalidad, se realizará la integración con la rama principal.

---

# Objetivo del Equipo

Desarrollar un proyecto organizado, mantenible y colaborativo, siguiendo una arquitectura común y respetando los estándares definidos en la documentación.
