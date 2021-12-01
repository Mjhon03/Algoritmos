using System;

namespace Año_biciesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo que determina si un año es bisiesto");
            Console.WriteLine("Ingrese el año");
            int year = int.Parse(Console.ReadLine());
            bool esBisiesto = ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
            if (esBisiesto)
            {
                Console.WriteLine("El año es bisiesto");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }

        }
    }
}
