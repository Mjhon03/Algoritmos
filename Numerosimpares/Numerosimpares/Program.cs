using System;

namespace Numerosimpares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros impares del 0 al 100");
            Console.WriteLine("Estos son los numeros impares que existen desde el 0 al 100");
            for (int i = 0; i <=100 ; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
