using System;
using System.Collections.Generic;
using System.IO;

namespace Conversiones
{
    public class Resultado
    {
        public string Nombre { get; set; }
        public bool Valor { get; set; }
        public string Mensaje { get; set; }
        public string Conversion { get; set; }

        public Resultado(string Nombre, bool Valor)
        {
            this.Nombre = Nombre;
            this.Valor = Valor;
        }

        public Resultado()
        {
        }
    }
    public class EjercicioConversiones
    {
        public static List<Resultado> ListarConversiones(string variable)
        {
            List<Resultado> lista = new List<Resultado>();

            lista.Add(ConvertirConParse(variable));
            lista.Add(ConvertirConTryParse(variable));
            lista.Add(ConvertirConConvert(variable));

            return lista;
        }

        public static Resultado ConvertirConParse(string variable)
        {
            Resultado resultado = new Resultado();
            resultado.Nombre = variable;
            resultado.Mensaje = "Se logró convertir";
            try
            {
                resultado.Valor = bool.Parse(variable);
            }
            catch
            {
                resultado.Mensaje = "No se logró convertir";
            }
            resultado.Conversion = "Parse";

            return resultado;
        }
        public static Resultado ConvertirConTryParse(string variable)
        {
            bool conversion = bool.TryParse(variable, out bool result);
            Resultado resultado = new Resultado(variable, result);
            if (conversion)
            {
                resultado.Mensaje = "Se logró convertir";
            }
            else
            {
                resultado.Mensaje = "No se logró convertir";
            }
            resultado.Conversion = "TryParse";
            return resultado;
        }

        public static Resultado ConvertirConConvert(string variable)
        {
            Resultado resultado = new Resultado();
            resultado.Nombre = variable;
            resultado.Mensaje = "Se logró convertir";
            try
            {
                resultado.Valor = bool.Parse(variable);
            }
            catch
            {
                resultado.Mensaje = "No se logró convertir";
            }
            resultado.Conversion = "Convert";

            return resultado;
        }

        public enum Color
        {
           Blanco = 1,
           Azul = 2,
           Negro = 3

        }

        public static string ObtenerDescripcionColor(Color color)
        {
            switch (color)
            {
                case Color.Blanco:
                    return "Blanco";
                case Color.Azul:
                    return "Azul";
                case Color.Negro:                    
                    return "Negro";
                default:
                    return "Vacio";
            }
        }
        public static string EsMayorADiez(int? variable)
        {
            string mensaje = "";
            if (variable > 10)
            {
                mensaje = "Es mayor a 10!";
            }
            return mensaje;
        }  
        public static void CicloWhile(int a)
        {
            while (a<50)
            {
                a =+ 5;
            }
        }
    }

}
