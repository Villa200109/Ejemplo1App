using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo1App.Models
{
    public class Peliculas : Controller
    {
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public DateTime Publicacion { get; set; }
        public string Pais { get; set; }
    }
}