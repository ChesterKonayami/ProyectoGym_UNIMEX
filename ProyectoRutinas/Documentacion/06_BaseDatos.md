# Joseph Mauricio Mondragón Moreno

# 06. Base de Datos

## Objetivo

Este documento describe la estructura oficial de la base de datos utilizada por el proyecto.

Todos deberán crear esta misma base de datos en su servidor local (XAMPP) antes de ejecutar el proyecto.

---

# Base de Datos

Nombre de la base de datos:
proyectogym

Motor de base de datos:
MySQL

Administrador:
phpMyAdmin (XAMPP)

---

# Tabla Principal

Nombre de la tabla:
tbl_usuarios

Esta tabla almacena la información necesaria para:

- Registro de usuarios.
- Inicio de sesión.
- Consulta del perfil.
- Actualización de datos.
- Eliminación de la cuenta.

---

# Estructura de la Tabla

|       Campo      |  Tipo   | Longitud |      Restricciones          |
|------------------|---------|----------|-----------------------------|
| ID_USUARIO       | INT     | 11       | PRIMARY KEY, AUTO_INCREMENT |
| NOMBRE           | VARCHAR | 50       | NOT NULL                    |
| APELLIDO_PATERNO | VARCHAR | 50       | NOT NULL                    |
| APELLIDO_MATERNO | VARCHAR | 50       | NOT NULL                    |
| EMAIL            | VARCHAR | 100      | NOT NULL                    |
| PASSWORD         | VARCHAR | 100      | NOT NULL                    |

---

# Llave Primaria

La llave primaria de la tabla es:
ID_USUARIO

Configuración:
- PRIMARY KEY
- AUTO_INCREMENT

El usuario no captura este valor durante el registro.

MySQL lo genera automáticamente.

---

# Uso de los Campos

|     Campo        |                 Descripción                       |
|------------------|---------------------------------------------------|
| ID_USUARIO       | Identificador único del usuario.                  |
| NOMBRE           | Nombre(s) del usuario.                            |
| APELLIDO_PATERNO | Primer apellido.                                  |
| APELLIDO_MATERNO | Segundo apellido.                                 |
| EMAIL            | Correo electrónico utilizado para iniciar sesión. |
| PASSWORD         | Contraseña utilizada para el inicio de sesión.    |

---

# Observaciones

- Todos deberán utilizar exactamente la misma estructura de la base de datos.
- No modificar nombres de tablas ni de campos.
- Cualquier cambio en la estructura deberá actualizar este documento antes de implementarse en el proyecto.

---

# Estado

Versión 1.0

Base de datos oficial del proyecto.