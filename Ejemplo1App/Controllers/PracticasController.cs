using Ejemplo1App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo1App.Controllers
{
    public class PracticasController : Controller
    {
        // GET: Practicas
        public ActionResult Index()
        {
            var personas = new Persona()
            {
                Nombre= "Carla",
                Edad = 20,
                Empleado = true,
                Nacimiento = new DateTime(2001, 5 ,4)
            };

            ViewBag.Propiedad = personas;
            return View();
        }
    }
}