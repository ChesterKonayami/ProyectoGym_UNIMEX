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

        // =========================================
        // Muestra la vista del perfil del usuario
        // =========================================
        public ActionResult Profile()
        {
            return View();
        }
    }
}