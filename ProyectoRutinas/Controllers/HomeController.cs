/*
 SEMANA 11
 GRUPO:SCOMA116
 CARRERA: SISTEMAS COMPUTACIONALES
 */

/*
=========================================================
PROYECTO: ProyectoRutinas
ARCHIVO: HomeController.cs

MÓDULO:
Navegación Pública

DESCRIPCIÓN:
Controlador principal de la aplicación.

RESPONSABILIDAD:
Gestionar las vistas públicas del sistema,
como la página de inicio y el contenido accesible
sin necesidad de iniciar sesión.
=========================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoRutinas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}