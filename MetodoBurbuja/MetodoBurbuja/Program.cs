 using System;

namespace MetodoBurbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0, conservarValores = 0;
            int[] numeros;

            Console.WriteLine("Cuantos numeros desea agregar");
            cantidad = int.Parse(Console.ReadLine());
            numeros = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Escribe el numero [{0}]: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int x = 1; x < cantidad; x++)
            {
                for (int j = 0; j < cantidad; j++)
                {
                    if (numeros[x]<numeros[j])
                    {
                        conservarValores = numeros[x];
                        numeros[x] = numeros[j];
                        numeros[j] = conservarValores;
                    }
                }
            }

            for (int k = 0; k < cantidad; k++)
            {
                Console.WriteLine("{0}.-{1}", k + 1, numeros[k]);
            }
        }
    }
}
