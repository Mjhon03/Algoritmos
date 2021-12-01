using System;

namespace ListaNombres_CRUD
{
    class Program
    {
        Methods methods = new Methods();
        static void Main(string[] args)
        {
            bool leave = false;
            while (leave == false)
            {
                Console.WriteLine("Menu de opciones");
                Console.WriteLine("1:Agregar nombres");
                Console.WriteLine("2:Eliminar nombre");
                Console.WriteLine("3:Actualizar nombre");
                Console.WriteLine("4:Buscar nombre");
                Console.WriteLine("5:Tamaño de la lista");
                Console.WriteLine("6:Ver lista");
                Console.WriteLine("7:Salir");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        string Addname = Methods.Addname();
                        Console.WriteLine(Addname);
                        break;
                    case 2:
                        Console.WriteLine(Methods.Deletename());
                        break;
                    case 3:
                        Console.WriteLine(Methods.Updatename());
                        break;
                    case 4:
                        Console.WriteLine(Methods.searchName());
                        break;
                    case 5:
                        Console.WriteLine(Methods.listLenght());
                        break;
                    case 6:
                        Methods.SortList();
                        break;
                    case 7:
                        leave = true;
                        break;
                }
            }
        }
    }
}
