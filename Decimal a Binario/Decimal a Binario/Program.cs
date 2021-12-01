using System;

namespace Decimal_a_Binario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converti un numero decimal a binario");
            Console.WriteLine("Introduzca el numero decimal");
            int numeroDecimal = int.Parse(Console.ReadLine());
            if (numeroDecimal > 0)
            {
                string cadena = "";
                while (numeroDecimal > 0)
                {
                    if (numeroDecimal % 2 == 0)
                    {
                        cadena = "0" + cadena;

                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numeroDecimal = (int)(numeroDecimal / 2);
                }
                Console.WriteLine(cadena);
            }
            else
            {
                if (numeroDecimal == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("Ingrese solo numeros positivos");
                }
            }
        }
    }
}
