/*
 SEMANA 11
 GRUPO: SCOMA116
 CARRERA: SISTEMAS COMPUTACIONALES
 */

/*
=========================================================
PROYECTO: ProyectoRutinas
ARCHIVO: ConexionBD.cs

MÓDULO:
Acceso a Datos

DESCRIPCIÓN:
Clase encargada de administrar la conexión con
la base de datos MySQL.

RESPONSABILIDAD:
Abrir, proporcionar y cerrar conexiones con la
base de datos para ser utilizadas por la capa
de servicios.
=========================================================
*/

using System.Configuration;
using MySql.Data.MySqlClient;

namespace ProyectoRutinas.Data
{
    public class ConexionBD
    {
        // =========================================
        // Configuración oficial de conexión
        // Proyecto: ProyectoRutinas
        // Servidor: 127.0.0.1
        // Base de datos: proyectogym
        // Usuario: root
        // Contraseña: (vacía)
        // =========================================

        private readonly string cadenaConexion =
            "Server=127.0.0.1;Database=proyectogym;Uid=root;Pwd=;";

        /// Crea y devuelve una conexión a la base de datos.
        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}