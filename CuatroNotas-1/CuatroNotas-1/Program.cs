using System;

namespace CuatroNotas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El promedio de prácticas de un curso se calcula con base en cuatro notas calificadas de las cuales se elimina la nota menor y se promedian las tres notas más altas.");
            Console.WriteLine("Para ello por favor digite la primera nota");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Para ello por favor digite la segunda nota");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Para ello por favor digite la tercera nota");
            float n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Para ello por favor digite la cuarta nota");
            float n4 = float.Parse(Console.ReadLine());
            if (n1<n2 && n2<n3 && n3<n4)
            {
                float promedio = n2 + n3 + n4 / 3;
                Console.WriteLine("El promedio es " + promedio);
            }
            if (n1 > n2 && n2 < n3 && n3 < n4)
            {
                float promedio = n1 + n3 + n4 / 3;
                Console.WriteLine("El promedio es " + promedio);
            }
            if (n1 > n2 && n2 > n3 && n3 < n4)
            {
                float promedio = n1 + n3 + n4 / 3;
                Console.WriteLine("El promedio es " + promedio);
            }
        }
    }
}
