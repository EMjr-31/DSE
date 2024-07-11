using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPeliculas.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome(string nombre, int numVeces = 1)
        {
            ViewData["nombres"] = "Hola " + nombre;
            ViewData["numVeces"] = numVeces;

            return View();

        }
    }
}
