using Generalidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPractica1.Controllers
{
    public class GeneralidadesController : Controller
    {

        public ActionResult Ejercicios()
        {
            return View();
        }

        public ActionResult Ejercicio1(int numero1, int numero2)
        {
            int suma = EjercicioGeneralidades.SumarDosNumeros(numero1, numero2);
            ViewBag.Suma = suma;
            return View("Ejercicios");
        }

        public ActionResult Ejercicio2(string cadena)
        {
            EjercicioGeneralidades.CortarCadena(ref cadena);
            ViewBag.Cadena = cadena;
            return View("Ejercicios");
        }

        public ActionResult Ejercicio3()
        {
            ViewBag.Fecha = EjercicioGeneralidades.ObtenerFechaActual();
            return View("Ejercicios");
        }
    }
}
