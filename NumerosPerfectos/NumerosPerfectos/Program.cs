using System;
using System.Collections.Generic;

namespace NumerosPerfectos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinar si un numero es perfecto");
            Console.WriteLine("Ingrese el numero que desea conocer");
            int numero = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            string n = "";
            for (int i = 1; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    suma = suma + i;
                    n = n + " + "+Convert.ToString(i);
                }
            }
                if (suma == numero)
                {  
                    Console.WriteLine("Multiplos " + n + " = " + numero );
                    Console.WriteLine($"{numero} Es perfecto");
                }
                else
                {
                    Console.WriteLine($"{numero} No Es perfecto");
                }
        }
    }
}
