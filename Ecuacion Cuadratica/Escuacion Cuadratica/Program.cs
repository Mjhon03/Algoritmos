using System;

namespace Escuacion_Cuadratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ecuación de la forma x = (-b +/ - RAIZ (b^2 - 4ac)) / 2a");
            Console.WriteLine("Ingre el valor de la variable A");
            float variableA = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingre el valor de la variable B");
            float variableB = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingre el valor de la variable C");
            float variableC = float.Parse(Console.ReadLine());

            double x1 = 0, x2 = 0;

            x1 = ((-1 * variableB) + Math.Sqrt(Math.Pow(variableB, 2) - (4 * variableA * variableC))) / (2 * variableA);
            x2 = ((-1 * variableB) - Math.Sqrt(Math.Pow(variableB, 2) - (4 * variableA * variableC))) / (2 * variableA);

            Console.WriteLine("El valor de x1 es: {0}", x1);
            Console.WriteLine("El valor de x2 es: {0}", x2);

        }
    }
}
