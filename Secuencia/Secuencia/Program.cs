using System;

namespace Secuencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Secuencia");
            Console.WriteLine("Defina el valor de N");
            int limite = Convert.ToInt32(Console.ReadLine());
            string textoSuma = "S = ";
            int positivo = 0;
            int negativo = 0;
            string mas = " + ";
            string men = " - ";
            int nose = 4;
            for (int i=0; i<=limite; i++)
            {
                if (i <= 2)
                {
                    positivo = positivo + nose;
                    if (negativo <2)
                    {
                        textoSuma = textoSuma + mas + positivo;
                        negativo = negativo + 1;
                    }
                    else
                    {
                        textoSuma = textoSuma + men + positivo;
                        negativo = 0;
                    }
                }
                if (i > 2 && i <= 5)
                {
                    positivo = positivo + (nose-1);
                    if (negativo < 2)
                    {
                        textoSuma = textoSuma + mas + positivo;
                        negativo = negativo + 1;
                    }
                    else
                    {
                        textoSuma = textoSuma + men + positivo;
                        negativo = 0;
                    }
                }
                if (i > 5 && i <= 8)
                {
                    positivo = positivo + (nose - 2);
                    if (negativo < 2)
                    {
                        textoSuma = textoSuma + mas + positivo;
                        negativo = negativo + 1;
                    }
                    else
                    {
                        textoSuma = textoSuma + men + positivo;
                        negativo = 0;
                    }
                }
                if (i > 8 && i <= 11)
                {
                    positivo = positivo + (nose - 3);
                    if (negativo < 2)
                    {
                        textoSuma = textoSuma + mas + positivo;
                        negativo = negativo + 1;
                    }
                    else
                    {
                        textoSuma = textoSuma + men + positivo;
                        negativo = 0;
                    }
                }


            }

            Console.WriteLine(textoSuma);


        }
    }
}
