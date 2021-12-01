using System;

namespace Peso_de_un_objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peso de un objecto");
            Console.WriteLine("Para calcular el peso de un objecto hace falta conocer su masa");
            Console.WriteLine("Digite la masa de objecto del cual desea conocer su peso");
            double masa = double.Parse(Console.ReadLine());
            const double gravedad = 9.8;
            double peso = masa * gravedad;

            Console.WriteLine("El peso del objeto es: " + peso);
        }
    }
}
