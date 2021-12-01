using System;

namespace Calculadora_alg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("1:Sumar" + "\n2:Restar" + "\n3:Multiplicar" + "\n2:Dividir");
            Console.WriteLine("Selecion la opcion");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    float suma = numero1 + numero2;
                    Console.WriteLine("El resulta es " + suma);
                    break;

                case 2:
                    float resta = numero1 - numero2;
                    Console.WriteLine("El resulta es " + resta);
                    break;

                case 3:
                    float multiplicacion = numero1 * numero2;
                    Console.WriteLine("El resulta es " + multiplicacion);
                    break;

                case 4:
                    float divicion = numero1 / numero2;
                    Console.WriteLine("El resulta es " + divicion);
                    break;
            }
        }
    }
}
