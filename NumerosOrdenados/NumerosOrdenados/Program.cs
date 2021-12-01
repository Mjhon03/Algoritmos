using System;

namespace NumerosOrdenados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo de ordenamiento para N numeros");
            Console.WriteLine("Digite la cantidad de numeros que desea agregar");
            int limite = Convert.ToInt32(Console.ReadLine());
            int[] lista = new int[limite]; 
            for (int i=0; i<limite; i++)
            {
                Console.WriteLine("Digite el numero que desea agregar");
                int numero = Convert.ToInt32(Console.ReadLine());
                lista[i] = numero;

            }
            int[] OrdenadoArray = new int[lista.Length];
            int valorMinimo = lista[0];
            int valorMaximo = lista[0];
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] < valorMinimo)
                {
                    valorMinimo = lista[i];
                }
                else if (lista[i] > valorMaximo)
                {
                    valorMaximo = lista[i];

                }
            }
            int[] conteo = new int[valorMaximo-valorMinimo+1];
            Console.WriteLine(conteo.Length);
            for (int i = 0; i < lista.Length; i++)
            {
                conteo[lista[i] - valorMinimo]++;
            }
            conteo[0]--;
            for (int i = 1; i < conteo.Length; i++)
            {
                conteo[i] = conteo[i] + conteo[i - 1];
            }

            // array ordenado
            for (int i = lista.Length - 1; i >= 0; i--)
            {
                OrdenadoArray[conteo[lista[i] - valorMinimo]--] = lista[i];
            }
            Console.WriteLine("\n" + "Array ordenado :");
            foreach (int i in OrdenadoArray)
            {
                Console.Write(" " + i);
            }
        }
    }
}
