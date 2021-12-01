using System;

namespace Teorema_de_Pitagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teorema de Pitagoras");
            Console.WriteLine("Digite la longitud del  cateto abyacente");
            int catetoAd = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la longitud del cateto opuesto");
            int catetoOp = int.Parse(Console.ReadLine());
            int hipotenusa = (catetoAd * catetoAd) + (catetoOp * catetoOp);
            Console.WriteLine("La medida de la hipotenusa es " + hipotenusa);
        }
    }
}
