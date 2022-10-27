using Ejemplo1App.Models;
using Ejemplo1App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;


namespace Ejemplo1App.Controllers
{
    public class OperasBasController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MuestraPeliculas()
        {
            var PeliculasService = new PeliculasServices();
            var model = PeliculasService.ObtenerPelicula();

            return View(model);
        }

        public ActionResult Sumar()
        {
            var tem = new Calculos();
            return View(tem);
        }

        [HttpPost]

            public ActionResult Sumar(Calculos calculos, string r1)
        {
            var tem = new Calculos();
            tem = calculos;

            

            if (r1.Equals("Sumar"))
            {
                tem.Sumar();
            }

            if (r1.Equals("Restar"))
            {
                tem.Resta();
            }



            ViewBag.res = tem.Resultado;
            return View();
        }

        //public ContentResult Temporal()
        //public ActionResult Temporal()
        //public JsonResult Temporal()
        //public RedirectResult Temporal()
        public RedirectToRouteResult Temporal()
        {
            //return Content("Hola Mundo");

            //bien    var alumno1 = new Alumno() { Nombre = "Frida", Edad = 15 };
            //bien    var alumno2 = new Alumno() { Nombre = "Carla", Edad = 25 };
            //return Json(alumno1,JsonRequestBehavior.AllowGet);

            //bien    return Json(new List<Alumno>() { alumno1, alumno2 }, JsonRequestBehavior.AllowGet);

            //return View();

            //return Redirect("https://google.com.mx");

            return RedirectToAction("About", "Home");
        }

        public ActionResult vista()
        {
            ViewBag.Nombre = "Frida";
            ViewData["Nom"] = "Carla";
            return View();
        }

    }
}