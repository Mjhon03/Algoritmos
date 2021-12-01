using System;

namespace Promediodenotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que pide tres notas de un alumno y calcula el promedio ");
            Console.WriteLine("Por favor ingre la primera nota ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingre la segunda nota ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingre la tercera nota ");
            float n3 = float.Parse(Console.ReadLine());

            float promedio = n1 + n2 + n3 / 3;
            if (promedio>10)
            {
                Console.WriteLine("Aprobado");
            }
            else if (promedio > 7 && promedio <= 9)
            {
                Console.WriteLine("Desaprobado");
            }
            else if (promedio < 7)
            {
                Console.WriteLine("Reprobado");
            }

        }
    }
}
