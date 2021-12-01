using System;

namespace Perimeto_y_superficie_de_un_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinar el perimetro y la superficie de un circulo");
            Console.WriteLine("Introduszco el radio del circulo");
            double rad = float.Parse(Console.ReadLine());
            double pi = Math.PI;
            double perimetro = 2 * pi * rad;

            Console.WriteLine("El perimetro del circulo es "+ perimetro);

            double superficie = pi * (rad * rad);
            Console.WriteLine("Y la superficie del circulo es " + superficie);

        }
    }
}
