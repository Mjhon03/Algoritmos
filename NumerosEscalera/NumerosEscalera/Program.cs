using System;

namespace NumerosEscalera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos numeros desea ver ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                for(int b = 1; b <= i; b++)
                {
                    Console.Write(b+" ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
