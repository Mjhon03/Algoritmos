using System;

namespace Serie5a5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int aux = 10;
            Console.WriteLine("Digite hasta que numero desea ver la serie");
            int limite = int.Parse(Console.ReadLine());
            for (int i = 0; i <= limite; i++)
            {
                for(int x = 0; x <= 5; x++)
                {
                    cont = aux + x;
                    Console.Write(cont+" ");
                }
                aux = cont + 5;
            }
        }
    }
}
