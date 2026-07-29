# JOSEPH MAURICIO MONDRAGÓN MORENO

# Flujo del Sistema

## Objetivo

Describir el funcionamiento general del sistema desde la interacción del usuario hasta el acceso a las diferentes funcionalidades del proyecto.

---

# Flujo General

Visitante

↓

Página de Inicio (Index)

↓

Explorar Rutina

↓

Registro (Opcional)

↓

Login

↓

Perfi de Usuario

---

# Descripción del Flujo

## 1. Página de Inicio

Es la primera pantalla del sistema.

Objetivos:

- Presentar el proyecto.
- Mostrar el propósito de la aplicación.
- Invitar al usuario a explorar el contenido.
- Permitir el acceso al registro o inicio de sesión.

---

## 2. Rutina

El usuario podrá visualizar una rutina de ejemplo sin necesidad de crear una cuenta.

Objetivos:

- Mostrar el funcionamiento de la plataforma.
- Permitir que el usuario conozca el contenido antes de registrarse.
- Incentivar el registro mediante el valor del contenido.

---

## 3. Registro

Si el usuario desea utilizar las funciones personales del sistema, deberá crear una cuenta.

El registro solicitará:

- Nombre
- Nickname
- Correo electrónico
- Contraseña

Al finalizar el registro, la información será almacenada en la base de datos.

---

## 4. Login

Permite autenticar al usuario mediante:

- Correo electrónico
- Contraseña

Si las credenciales son correctas, el usuario accederá a su perfil.

---

## 5. Perfil

Una vez autenticado, el usuario podrá administrar su información personal.

Funciones disponibles:

- Consultar información.
- Actualizar datos.
- Eliminar cuenta.

---

# Flujo de Arquitectura

Usuario

↓

View (.cshtml)

↓

Controller

↓

Service

↓

Data

↓

Base de Datos

La respuesta seguirá el mismo recorrido en sentido contrario.

---

# Flujo del CRUD

## Crear

Registro de un nuevo usuario.

↓

Base de Datos.

---

## Consultar

Obtención de la información del usuario autenticado.

↓

Base de Datos.

---

## Actualizar

Modificación de los datos del usuario.

↓

Base de Datos.

---

## Eliminar

Eliminación de la cuenta del usuario.

↓

Base de Datos.

---

# Flujo de Navegación

Index

↓

Rutina

↓

Registro

↓

Login

↓

Perfil

El usuario podrá navegar libremente por las páginas públicas del sistema.

Las funciones relacionadas con la administración de la cuenta requerirán autenticación.

---

# Alcance de la Primera Versión

La versión inicial del proyecto incluirá únicamente:

- Página de Inicio.
- Rutina de ejemplo.
- Registro de usuarios.
- Inicio de sesión.
- Perfil de usuario.
- CRUD de usuario.

No se implementarán en esta versión:

- Múltiples rutinas.
- Seguimiento de progreso.
- Rutinas personalizadas.
- Favoritos.
- Historial.
- Panel de administración.
- Integración con APIs externas.

---

# Filosofía del Proyecto

El usuario podrá conocer el contenido principal del sistema sin necesidad de registrarse.

El registro únicamente será requerido cuando el usuario desee acceder a funciones personalizadas relacionadas con su cuenta.

Esta estrategia busca ofrecer una experiencia de usuario más abierta, permitiendo que el valor de la plataforma sea percibido antes de solicitar información personal.
