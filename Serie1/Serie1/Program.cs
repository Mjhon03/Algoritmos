using System;

namespace Serie1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*bool f = false;
            int of = 1;
            while (f == false)
            {
                Console.WriteLine("Cuantos numeros desea ver");
                int limite = int.Parse(Console.ReadLine());
                for (int i=1;i<=limite;i++)
                {
                    Console.Write(of);
                    Console.WriteLine(of+""+i);

                }
                of = of + 1;

            }
            Console.WriteLine("Cuantos numeros desea ver");
            int nose = int.Parse(Console.ReadLine());*/


            /*Console.WriteLine("S=1/3 + 2/4+ 3/5 n/n+2");
            Console.WriteLine("Cuantos numeros desea ver");
            int numeros = int.Parse(Console.ReadLine());
            Console.WriteLine("S= ");
            string s = "S= ";
            float suma = 0;
            float dev;
            for (int i = 1; i <= numeros; i++)
            {
                float num = i;
                float dem = num + 2;
                dev = num / dem;
                suma = suma + dev;
                Console.Write( num + "/"+dem+" ");
            }
            Console.WriteLine("\nResultado de la suma "+suma);*/

            Console.WriteLine("S=1+2-3+6+7-8+11");
            Console.WriteLine("Cuantos numeros desea ver");
            int n = int.Parse(Console.ReadLine());
            string texto = "S= ";
            int cont = 0;
            int valor = 1;
            int nose = 0;
            for (int x = 1; x <= n; x++)
            {
                if (cont <= 2)
                {
                    texto = texto + " + "+nose;
                    if (valor == 4)
                    {
                        nose = nose + 2;
                        valor = 0;
                    
                    }
                    valor = valor + 1;
                    nose = nose + 1;
                    cont = cont + 1;
                }
                else
                {
                    texto = texto + " - " + nose;
                    if (valor == 4)
                    {
                        nose = nose + 2;
                        valor = 0;

                    }
                    valor = valor + 1;
                    nose = nose + 1;
                    cont = 1;
                }

            }
            Console.WriteLine(texto.Remove(4,5));

        }
    }
}
