/* CONEXIONES DE PAGINAS LINKS DE NAVEGACIONES A PAGINAS */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal_Literario.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inventario()
        {
            ViewBag.Message = "Administrar la mercancia de la biblioteca.";

            return View();
        }

        public ActionResult Préstamos()
        {
            ViewBag.Message = "Administrar los restamos de los usuarios.";

            return View();
        }

        public ActionResult Devoluciones()
        {
            ViewBag.Message = "Administrar las devoluciones de los usuarios.";

            return View();
        }

        public ActionResult Reservas()
        {
            ViewBag.Message = "Administrar las reservas de los usuarios";

            return View();
        }

        public ActionResult Recomendaciones()
        {
            ViewBag.Message = "Administrar las preferencias de los usuarios segun su movimientos";

            return View();
        }

        public ActionResult Usuarios()
        {
            ViewBag.Message = "Administrar los datos y roles de los perfiles";

            return View();
        }


        public ActionResult Salir()
        {
            ViewBag.Message = "Salir del sitio web";

            return View();
        }
    }
}