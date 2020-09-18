using System;

namespace Enumeraciones
{
       public class EjercicioEnumeraciones
    {
        public enum DiaDeLaSemana
        {
            Domingo = 1,
            Lunes = 2,
            Martes = 3,
            Miercoles = 4,
            Jueves = 5,
            Viernes = 6,
            Sabados = 7
        }

        public static string ObtenerDiasDeLaSemana(DiaDeLaSemana diaDeLaSemana)
        {
            switch (diaDeLaSemana)
            {
                case DiaDeLaSemana.Domingo:
                    return "Domingo";
                case DiaDeLaSemana.Lunes:
                    return "Lunes";
                case DiaDeLaSemana.Martes:
                    return "Martes";
                case DiaDeLaSemana.Miercoles:
                    return "Miércoles";
                case DiaDeLaSemana.Jueves:
                    return "Jueves";
                case DiaDeLaSemana.Viernes:
                    return "Viernes";
                case DiaDeLaSemana.Sabados:
                    return "Sábado";
                default:
                    return "Vacio";
            }
        }
    }
}
