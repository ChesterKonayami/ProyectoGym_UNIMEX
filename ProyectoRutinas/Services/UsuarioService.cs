/*
 SEMANA 11
 GRUPO: SCOMA116
 CARRERA: SISTEMAS COMPUTACIONALES

 RAMA: MONDRAGON MORENO JOSEPH MAURICIO
 */

/*
=========================================================
PROYECTO: ProyectoRutinas
ARCHIVO: UsuarioService.cs

MÓDULO:
Servicios de Usuario

DESCRIPCIÓN:
Servicio encargado de la lógica de negocio
relacionada con los usuarios.

RESPONSABILIDAD:
Implementar las operaciones CRUD y coordinar
la comunicación entre los controladores y la
base de datos.
=========================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using ProyectoRutinas.Data;
using ProyectoRutinas.Models;
using System.Web.Security;

namespace ProyectoRutinas.Services
{
    public class UsuarioService
    {
        // =========================================
        // REGISTRAR USUARIO
        // =========================================

        public bool RegistrarUsuario(Usuario usuario)
        {
            // =========================================
            // CREAR OBJETO DE CONEXIÓN
            // =========================================

            ConexionBD conexionBD = new ConexionBD();

            // =========================================
            // OBTENER LA CONEXIÓN A MYSQL
            // =========================================

            MySqlConnection conexion = conexionBD.ObtenerConexion();

            // =========================================
            // CONSULTA SQL PARA REGISTRAR UN USUARIO
            // =========================================

            string consulta = @"
                INSERT INTO tbl_usuarios
                (
                    NOMBRE,
                    APELLIDO_PATERNO,
                    APELLIDO_MATERNO,
                    EMAIL,
                    PASSWORD
                )
                VALUES
                (
                    @Nombre,
                    @ApellidoPaterno,
                    @ApellidoMaterno,
                    @Email,
                    @Password
                )";

            // =========================================
            // CREAR EL COMANDO MYSQL
            // =========================================

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            // =========================================
            // ASIGNAR LOS PARÁMETROS DE LA CONSULTA SQL
            // =========================================

            comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@ApellidoPaterno", usuario.ApellidoPaterno);
            comando.Parameters.AddWithValue("@ApellidoMaterno", usuario.ApellidoMaterno);
            comando.Parameters.AddWithValue("@Email", usuario.Email);
            comando.Parameters.AddWithValue("@Password", usuario.Password);

            // =========================================
            // ABRIR LA CONEXIÓN CON LA BASE DE DATOS
            // =========================================

            conexion.Open();

            // =========================================
            // EJECUTAR LA CONSULTA SQL
            // =========================================

            int filasAfectadas = comando.ExecuteNonQuery();

            // =========================================
            // CERRAR LA CONEXIÓN
            // =========================================

            conexion.Close();

            // =========================================
            // DEVOLVER EL RESULTADO DE LA OPERACIÓN
            // =========================================

            return filasAfectadas > 0;
        }

        // =========================================
        // VERIFICAR SI EL CORREO YA EXISTE
        // =========================================

        public bool ExisteCorreo(string email)
        {
            // Crear la conexión
            ConexionBD conexionBD = new ConexionBD();

            MySqlConnection conexion = conexionBD.ObtenerConexion();

            // Consulta SQL
            string consulta = @"
            SELECT COUNT(*)
            FROM tbl_usuarios
            WHERE EMAIL = @Email";

            MySqlCommand comando =
                new MySqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@Email", email);

            conexion.Open();

            int cantidad =
                Convert.ToInt32(comando.ExecuteScalar());

            conexion.Close();

            return cantidad > 0;
        }
    }


}
