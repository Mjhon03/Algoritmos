using System;

namespace Producto_de_los_numeros_positivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular el producto de los números positivos comprendidos desde el 1 hasta el 2000, ambos inclusive");
            int limite = 2000;
            int numero = 1;
            int suma = 0;
            while (limite!=0)
            {
                numero = numero * limite;
                limite = limite - 1;
                suma = suma + numero;
            }
            Console.WriteLine("El resultado del producto de los numeros positivos compredidos desde el 1 hasta el 200 es "+suma);
        }
    }
}
