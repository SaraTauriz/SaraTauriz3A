using System;

namespace Programa_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un número para generar la tabla de multiplicar: ");
            string número = Console.ReadLine();
            Int16.TryParse(número, out short TabladeMultiplicar);
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("{0}x{1}={2}", número, i, TabladeMultiplicar * i);

            }
            Console.ReadKey();
        }
    }
}
