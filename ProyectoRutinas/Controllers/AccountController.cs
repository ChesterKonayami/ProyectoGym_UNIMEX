/*
 SEMANA 11
 GRUPO: SCOMA116
 CARRERA: SISTEMAS COMPUTACIONALES

 RAMA: MONDRAGON MORENO JOSEPH MAURICIO
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
using ProyectoRutinas.Models;
using ProyectoRutinas.Services;
using System;
using System.Web.Mvc;

namespace ProyectoRutinas.Controllers
{
    public class AccountController : Controller
    {
        // =========================================
        // MUESTRA LA VISTA DE REGISTRO
        // =========================================

        // =========================================
        // MUESTRA LA VISTA DE REGISTRO
        // =========================================

        [HttpGet]
        public ActionResult Register()
        {
            // =========================================
            // MENSAJE INICIAL DEL PANEL DE ESTADO
            // =========================================

            ViewBag.TituloEstado = "Crear una cuenta";

            ViewBag.MensajeEstado =
                "Regístrese primero para activar el inicio de sesión.";

            ViewBag.RegistroExitoso = false;

            return View();
        }

        // =========================================
        // RECIBE LA INFORMACIÓN DEL FORMULARIO
        // =========================================

        [HttpPost]
        public ActionResult Register(Usuario usuario)
        {
            // =========================================
            // ELIMINAR ESPACIOS AL INICIO Y AL FINAL
            // =========================================

            usuario.Nombre = usuario.Nombre?.Trim();
            usuario.ApellidoPaterno = usuario.ApellidoPaterno?.Trim();
            usuario.ApellidoMaterno = usuario.ApellidoMaterno?.Trim();
            usuario.Email = usuario.Email?.Trim();
            usuario.Password = usuario.Password?.Trim();
            usuario.ConfirmarPassword = usuario.ConfirmarPassword?.Trim();

            // =========================================
            // VALIDAR LOS DATOS DEL FORMULARIO
            // =========================================

            if (!ModelState.IsValid)
            {
                ViewBag.RegistroExitoso = false;

                return View(usuario);
            }

            // =========================================
            // VALIDAR QUE LAS CONTRASEÑAS COINCIDAN
            // =========================================

            if (usuario.Password != usuario.ConfirmarPassword)
            {
                // Agregar el mensaje de error al campo
                // ConfirmarPassword
                ModelState.AddModelError(
                    "ConfirmarPassword",
                    "Las contraseñas no coinciden.");

                ViewBag.RegistroExitoso = false;

                return View(usuario);
            }

            // Crear el servicio de usuarios
            UsuarioService usuarioService = new UsuarioService();

            // =========================================
            // VALIDAR QUE EL CORREO NO EXISTA
            // =========================================

            if (usuarioService.ExisteCorreo(usuario.Email))
            {
                ModelState.AddModelError(
                    "Email",
                    "Ese correo electrónico ya está registrado.");

                ViewBag.RegistroExitoso = false;

                ViewBag.TituloEstado = "Crear una cuenta";

                ViewBag.MensajeEstado =
                    "Regístrese primero para activar el inicio de sesión.";

                return View(usuario);
            }

            // Registrar el usuario en la base de datos
            bool registrado = usuarioService.RegistrarUsuario(usuario);

            // =========================================
            // SI EL REGISTRO FUE EXITOSO
            // =========================================

            if (registrado)
            {
                ViewBag.RegistroExitoso = true;

                ViewBag.TituloEstado = "¡Registro exitoso!";

                ViewBag.MensajeEstado =
                    "Ya puede iniciar sesión.";

                // =========================================
                // LIMPIAR EL FORMULARIO
                // =========================================

                ModelState.Clear();

                return View();
            }

            // =========================================
            // SI OCURRIÓ UN ERROR
            // =========================================

            ViewBag.RegistroExitoso = false;

            ViewBag.TituloEstado = "Crear una cuenta";

            ViewBag.MensajeEstado =
                "Regístrese primero para activar el inicio de sesión.";

            return View(usuario);
        }


        // =========================================
        // MUESTRA LA VISTA DE INICIO DE SESIÓN
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
                    Session["ID_USUARIO"] = dr["ID_USUARIO"];
                    return RedirectToAction("Profile");
                }
            }

            ViewBag.Error = "Correo o contraseña incorrectos";
            return View();
        }

        // =========================================
        // MUESTRA LA VISTA DEL PERFIL
        // =========================================

        public ActionResult Profile()
        {
            // =========================================
            // VALIDAR QUE EXISTA UNA SESIÓN
            // =========================================

            if (Session["ID_USUARIO"] == null)
            {
                return RedirectToAction("Login");
            }

            int idUsuario = Convert.ToInt32(Session["ID_USUARIO"]);

            Usuario usuario = new Usuario();

            ConexionBD conexionBD = new ConexionBD();

            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"SELECT
                           ID_USUARIO,
                           NOMBRE,
                           APELLIDO_PATERNO,
                           APELLIDO_MATERNO,
                           EMAIL
                       FROM tbl_usuarios
                       WHERE ID_USUARIO = @idUsuario";

                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    usuario.IdUsuario = Convert.ToInt32(dr["ID_USUARIO"]);
                    usuario.Nombre = dr["NOMBRE"].ToString();
                    usuario.ApellidoPaterno = dr["APELLIDO_PATERNO"].ToString();
                    usuario.ApellidoMaterno = dr["APELLIDO_MATERNO"].ToString();
                    usuario.Email = dr["EMAIL"].ToString();
                }
            }

            return View(usuario);
        }
    }
}