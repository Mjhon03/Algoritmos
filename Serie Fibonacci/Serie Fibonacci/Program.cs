using System;

namespace Serie_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 1;
            int C = A + B;
            int suma = 0;

            Console.WriteLine("Serie Fibonacci: "); 
            Console.Write(A + " "); 
            Console.Write(B + " "); 
            while (C < 10000) { 
                Console.Write(C + " "); 
                if (C > 100 && C < 10000) 
                { 
                    suma = suma + C; 
                } 
                A = B; 
                B = C; 
                C = A + B; 
            } 
            Console.WriteLine("La Suma es: " + suma); 
        }
    }
}
