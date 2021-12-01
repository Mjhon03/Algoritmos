using System;

namespace Factorial_de_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial de un numero dado");
            Console.WriteLine("Ingrese el numero del cual desea conocer su factorial");
            int numero = int.Parse(Console.ReadLine());
            int factorial = 1;
            while (numero != 0)
            {
                factorial = factorial * numero;
                numero = numero - 1;
            }
            Console.WriteLine(factorial);
        }
    }
}
