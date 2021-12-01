using System;

namespace Ordernar_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int tp = 0, ts = 0;
            int[] numeros;
            Console.WriteLine("Digite la cantidad de numeros que desea ingresar: ");
            tp = int.Parse(Console.ReadLine());
            numeros = new int[tp];
            for (int i = 0; i < tp; i++)
            {
                Console.WriteLine("Ingresar el numero");
                numeros[i] = int.Parse(Console.ReadLine());

            }
            for (int x = 1; x < tp; x++)
            {
                for (int j = 0; j < tp - 1; x++)
                {
                    if (numeros[x] < numeros[j])
                    {
                        ts = numeros[x];
                        numeros[x] = numeros[j];
                        numeros[j] = ts;
                    }
                }
            }
            for (int q = 1; q < tp; q++)
            {
                Console.Write(numeros[q] + " - ");
            }
        }
               
    }
}
