using System;

namespace Generalidades
{
    public class EjercicioGeneralidades
    {
        //1)Crear una función que devuelva la suma de dos números recibidos por parámetros
        public static int SumarDosNumeros(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            return suma;
        }
        public static void CortarCadena(ref string cadena)
        {
            cadena = cadena.Substring(0, 4);
        }
        public static string ObtenerFechaActual()
        {
            string fecha = DateTime.Now.ToString();
            return fecha;
        }
    }
}
