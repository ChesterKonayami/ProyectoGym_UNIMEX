/*
 SEMANA 12
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
        // Joseph Mauricio Mondragón Moreno
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
/*
=========================================================
PROYECTO: Fit Rutinas

VERSIÓN: 1.0
ESTADO: Versión Final (MVP)
FECHA: 27 y 29 de julio de 2026
CARRERA: Sistemas Compuacionales
GRUPO: SCOMA116

Erik Alexander Aguilar Reyes
Adhara Paola Bass Salazar
Fernanda Roberta Flores Garduño
Joseph Mauricio Mondragón Moreno

Esta versión corresponde a la entrega final del sistema.
=========================================================
 */