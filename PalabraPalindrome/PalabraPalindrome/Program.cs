using System;

namespace PalabraPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una plabra y te dire si es Palindrome");
            string palabra, inverso, caracter;
            int count;
            Console.WriteLine("Digite la palabra: ");
            palabra = Console.ReadLine();
            count = palabra.Length;
            inverso = "";
            for (int i =count-1; i >= 0; i--)
            {
                caracter = palabra.Substring(i, 1);
                inverso = inverso + caracter;
            }
            if (palabra == inverso)
            {
                Console.WriteLine("La palabra es palindrome");
            }
            else
            {
                Console.WriteLine("La palabra no es palindrome");

            }
        }
    }
}
