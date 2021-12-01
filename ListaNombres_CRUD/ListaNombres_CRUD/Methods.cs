using System;
using System.Collections.Generic;
using System.Text;

namespace ListaNombres_CRUD
{
    public class Methods
    {
        CGlobal CGlobal = new CGlobal();
        public static List<string> names = new List<string>();


        public static string Addname()
        {
            Console.WriteLine("Cuantos nombres desea agregar: ");
            int cont = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine("Digite el nombre para agregar: ");
                string names = Console.ReadLine();
                if (CGlobal.name.Contains(names))
                {
                    Console.WriteLine("No se permiten nombres valores repetidos");
                    int indice = CGlobal.name.IndexOf(names);
                    Console.WriteLine($"El nombre {names} se encuentra en la posicion {indice} ");
                }
                else
                {
                    CGlobal.name.Add(names);
                    Console.WriteLine("Se agrego correctamente");
                }
            }
            return "";
        }
        public static string Deletename()
        {
            Console.WriteLine("Digite el nombre que desea eliminar: ");
            string name = Console.ReadLine();
            int indice = CGlobal.name.IndexOf(name);
            CGlobal.name.Remove(CGlobal.name[indice]);
            return "Se elimino correctamente ";
        }

        public static string Updatename()
        {
            Console.WriteLine("Digite el nombre que desea editar: ");
            string name = Console.ReadLine();
            int indice = CGlobal.name.IndexOf(name);
            Console.WriteLine("Digite el nuevo nombre: ");
            string Newname = Console.ReadLine();
            CGlobal.name[indice] = Newname;


            return "Se actualizo correctamente ";

        }

        public static string listLenght()
        {
            int lenght = CGlobal.name.Count;
            string result = $"El tamaño de la lista es de {lenght} elementos";
            return result;
        }
        public static string searchName()
        {
            Console.WriteLine("Digite el nombre que desea buscar: ");
            string name = Console.ReadLine();
            foreach (string item in CGlobal.name)
            {
                if (name == item)
                {
                    int indice = CGlobal.name.IndexOf(item);
                    Console.WriteLine($"El nombre {item} se encuentra en la posicion {indice} ");
                }

            }
            return " ";
        }
        public static string SortList()
        {

            CGlobal.name.Sort();
            Console.WriteLine("Lista Ordenada");

            foreach (string i in CGlobal.name)
            {
                Console.WriteLine("{0}", i);
            }
            return "";
        }
    }
}
