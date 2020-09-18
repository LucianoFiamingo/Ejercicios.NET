using Antlr.Runtime.Misc;
using Conversiones;
using Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPractica1.Controllers
{
    public class ConversionesController : Controller
    {

        public ActionResult Ejercicios()
        {
            return View();
        }

        public ActionResult Ejercicio1()
        {
            string variable1 = "true";
            string variable2 = "false";
            string variable3 = "1";
            string variable4 = "0";

            List<Resultado> lista = new List<Resultado>();

            lista.AddRange(EjercicioConversiones.ListarConversiones(variable1));
            lista.AddRange(EjercicioConversiones.ListarConversiones(variable2));
            lista.AddRange(EjercicioConversiones.ListarConversiones(variable3));
            lista.AddRange(EjercicioConversiones.ListarConversiones(variable4));

            return View("Ejercicios", lista);
        }

        public ActionResult Ejercicio2()
        {
            //a) 
            int a = (int)344.4;
            ViewBag.A = a;

            //b) 
            decimal b = 10;
            ViewBag.B = b;

            //c) 
            int c = 443444;
            ViewBag.C = c;

            //d) 
            short d = (short)a; 
            ViewBag.D = d;

            return View("Ejercicios");
        }
        public ActionResult Ejercicio4(int? a)
        {
            ViewBag.Mensaje = EjercicioConversiones.EsMayorADiez(a);

            return View("Ejercicios");

        }
        
        public ActionResult Ejercicio5(int? a)
        {
            string mensaje;
            if (a > 10)
            {
                mensaje = "Es mayor a 10!";
            }
            else
            {
                mensaje = "Error, no es mayor a 10";
            }
            ViewBag.Mensaje2 = mensaje;

            return View("Ejercicios");
        } 
    }
}
