using System;
using System.Collections.Generic;

namespace CalcularEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dijite su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Dijite su fecha de nacimiento" + "\n (dd/mm/yyyy)");
            string edad = Console.ReadLine();

            string[] arreglo = edad.Split('/');
            var dateandtime = DateTime.Now;
            var Date = dateandtime.ToShortDateString();
            string[] arr = Date.Split('/');


            int day = Convert.ToInt32(arreglo[0]);
            int currentDay = Convert.ToInt32(arr[1]);
            int month = Convert.ToInt32(arreglo[1]);
            int currentMonth = Convert.ToInt32(arr[0]);
            int year = Convert.ToInt32(arreglo[2]);
            int currentYear = Convert.ToInt32(arr[2]);

            int letfMonth = 12 - (currentMonth);

            int resyear = year - currentYear;
            int resmonth = month - currentMonth;
            int resday = day - currentDay;

            if (resyear >= -18)
            {
                if (resmonth <= letfMonth)
                {
                    if(resday < 0)
                    {
                        Console.WriteLine($"{nombre} puede votar ");
                    }
                    else
                    {
                        Console.WriteLine($"{nombre} No puede votar ");

                    }
                }
            }
            else
            {
                Console.WriteLine($"{nombre} Puede votar ");

            }
        }
    }
}
