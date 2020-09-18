using Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPractica1.Controllers
{
    public class EnumeracionesController : Controller
    {

        public ActionResult Ejercicios()
        {
            return View();
        }

        public ActionResult DiaDeLaSemana()
        {
            Random ran = new Random(DateTime.Now.Millisecond);
            int dia = ran.Next(1, 8);
            string nombreDia = EjercicioEnumeraciones.ObtenerDiasDeLaSemana((EjercicioEnumeraciones.DiaDeLaSemana)dia);
            ViewBag.NombreDia = nombreDia;
            return View("Ejercicios");
        }
    }
}
