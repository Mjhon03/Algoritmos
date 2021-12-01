using System;

namespace Primos_de_la_serie_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] Serie = new long[30]; 
            long suma = 0; 
            int cind = 0;
            int A = 0; 
            int B = 1; 
            int C = A + B; 
            int cont = 3;
            int num; 
            int div = 0;
            Serie[0] = A; 
            Serie[1] = B;
            Serie[2] = C; 
            Console.WriteLine("Serie Fibonacci: "); 
            Console.WriteLine("================="); 
            Console.Write(Serie[0] + " "); 
            Console.Write(Serie[1] + " ");
            Console.Write(Serie[2] + " ");
            while (C < 10000) { 
                A = B; 
                B = C; 
                C = A + B; 
                Serie[cont] = C; 
                Console.Write(Serie[cont] + " "); 
                cont += 1; 
            }
            Console.Write("Ingrese un valor numérico: "); 
            num = int.Parse(Console.ReadLine()); 
            for (int x = 0; x < cont; x++) {
                if (Serie[x]<=num) { 
                    cind = x+1; 
                }
            } 
            Console.WriteLine(); 
            Console.WriteLine("Números primos de la serie Fibonacci menores que " + num + ":");
            for (int i = 0; i < cind; i++) { 
                for (int j = 1; j <= i; j++) {
                    if (Serie[i] % j == 0) {
                        div += 1; 
                    } 
                } 
                if (div == 1 || div == 2) {
                    Console.Write(Serie[i] + " ");
                    suma = suma + Serie[i]; 
                } 
                div = 0;
            }
            Console.WriteLine("Suma: " + suma);
            Console.ReadLine(); 
        
        }
    }
}
