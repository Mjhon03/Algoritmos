using System;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero");
            int number = Convert.ToInt32(Console.ReadLine());
            int cont = 0;
            for (int i = 1; i <= number; i++) 
            {
                if (number % i == 0){
                    cont = cont + 1;
                }
            }
            if(cont == 2)
            {
                Console.WriteLine($"{number} es primo");
            }
            else
            {
                Console.WriteLine($"{number} No es primo");

            }
        }
    }
}
