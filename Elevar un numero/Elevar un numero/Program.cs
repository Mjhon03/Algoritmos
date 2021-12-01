using System;

namespace Elevar_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elevar un numero por una potencia dada");
            Console.WriteLine("Digite el numero que desea potenciar");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el expotente");
            int expo = int.Parse(Console.ReadLine());
            double elevar = Math.Pow(numero, expo);
            Console.WriteLine("El resultado de la pontecia es " + elevar);
        }
    }
}
