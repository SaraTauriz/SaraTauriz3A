using System;

namespace Programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el número para realizar el cuadrado: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 0 && numero <= 100)
            {
                for (int i = 0; i < numero; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                for (int i = 0; i < numero - 2; i++)
                {
                    Console.Write("*");
                    for (int j = 0; j < numero - 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
                for (int i = 0; i < numero; i++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
