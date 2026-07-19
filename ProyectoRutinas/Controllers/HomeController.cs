/*
 SEMANA 11
 GRUPO: SCOMA116
 CARRERA: SISTEMAS COMPUTACIONALES
*/

/*
=========================================================
PROYECTO: ProyectoRutinas
ARCHIVO: HomeController.cs

MÓDULO:
Navegación Pública

DESCRIPCIÓN:
Controlador principal encargado de administrar
las vistas públicas de la aplicación.

RESPONSABILIDAD:
Gestionar la navegación entre la página de inicio
y la sección de rutinas, disponibles para cualquier
usuario sin necesidad de iniciar sesión.
=========================================================
*/

using System.Web.Mvc;

namespace ProyectoRutinas.Controllers
{
    public class HomeController : Controller
    {
        // =========================================
        // Página principal de la aplicación
        // =========================================
        public ActionResult Index()
        {
            return View();
        }

        // =========================================
        // Muestra la rutina de entrenamiento
        // =========================================
        public ActionResult Rutina()
        {
            return View();
        }
    }
}