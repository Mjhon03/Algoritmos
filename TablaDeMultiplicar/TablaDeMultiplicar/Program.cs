using System;

namespace TablaDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabla de multiplicar de un numero dado");
            Console.WriteLine("Escriba en numero del cual desea conocer su tabla de multiplicacion");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine(numero+" * "+i +" = "+resultado);
            }
        }
    }
}
