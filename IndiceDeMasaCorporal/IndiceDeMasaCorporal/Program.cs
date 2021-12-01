using System;

namespace IndiceDeMasaCorporal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorito para determinar el indice de masa corporal");
            Console.WriteLine("Para ello por favor, digite su peso en kilogramos");
            float peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Y ahora su altura en metros");
            float altura = float.Parse(Console.ReadLine());
            float IMC = peso / (altura * altura);
            Console.WriteLine("Su indice de masa corporal es de "+ IMC);

        }
    }
}
