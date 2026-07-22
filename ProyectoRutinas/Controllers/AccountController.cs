/*
 SEMANA 11
 GRUPO:SCOMA116
 CARRERA: SISTEMAS COMPUTACIONALES
 */

/*
=========================================================
PROYECTO: ProyectoRutinas
ARCHIVO: AccountController.cs

MÓDULO:
Gestión de Usuarios

DESCRIPCIÓN:
Controlador encargado de administrar las funciones
relacionadas con la cuenta del usuario.

RESPONSABILIDAD:
Gestionar el registro, inicio de sesión, perfil
y demás operaciones relacionadas con la cuenta
del usuario.
=========================================================
*/

using MySql.Data.MySqlClient;
using ProyectoRutinas.Data;
using System.Web.Mvc;

namespace ProyectoRutinas.Controllers
{
    public class AccountController : Controller
    {
        // =========================================
        // Muestra la vista de registro de usuarios
        // =========================================
        public ActionResult Register()
        {
            return View();
        }

        // =========================================
        // Muestra la vista de inicio de sesión
        // =========================================
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            ConexionBD conexionBD = new ConexionBD();

            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = "SELECT * FROM tbl_usuarios WHERE EMAIL=@email AND PASSWORD=@password";

                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return RedirectToAction("Profile");
                }
            }

            ViewBag.Error = "Correo o contraseña incorrectos";
            return View();
        }

        // =========================================
        // Muestra la vista del perfil del usuario
        // =========================================
        public ActionResult Profile()
        {
            return View();
        }
    }
}