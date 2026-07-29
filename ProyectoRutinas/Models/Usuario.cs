/*
 SEMANA 11
 GRUPO: SCOMA116
 CARRERA: SISTEMAS COMPUTACIONALES

 RAMA: MONDRAGON MORENO JOSEPH MAURICIO
 */

/*
=========================================================
PROYECTO: ProyectoRutinas
ARCHIVO: Usuario.cs

MÓDULO:
Modelos

DESCRIPCIÓN:
Modelo que representa la entidad Usuario.

RESPONSABILIDAD:
Almacenar la información del usuario y transportar
los datos entre la base de datos, los servicios
y las vistas.
=========================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyectoRutinas.Models
{
    public class Usuario
    {
        // =========================================
        // IDENTIFICADOR DEL USUARIO
        // =========================================

        public int IdUsuario { get; set; }

        // =========================================
        // DATOS PERSONALES
        // =========================================

        [Required(ErrorMessage = "Ingrese su nombre.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese su apellido paterno.")]
        public string ApellidoPaterno { get; set; }

        [Required(ErrorMessage = "Ingrese su apellido materno.")]
        public string ApellidoMaterno { get; set; }

        // =========================================
        // DATOS DE ACCESO
        // =========================================

        [Required(ErrorMessage = "Ingrese un correo electrónico.")]
        [EmailAddress(ErrorMessage = "Ingrese un correo electrónico.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ingrese una contraseña.")]
        public string Password { get; set; }

        // =========================================
        // CONFIRMACIÓN DE CONTRASEÑA
        // =========================================
        // Esta propiedad únicamente se utiliza
        // durante el registro para verificar
        // que ambas contraseñas coincidan.
        //
        // No se almacena en la base de datos.

        [Required(ErrorMessage = "Confirme su contraseña.")]
        public string ConfirmarPassword { get; set; }
    }
}