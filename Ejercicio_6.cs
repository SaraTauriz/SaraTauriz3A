using System;

namespace Programa_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int número, l, es, aster;
            Console.WriteLine("Ingrese un número para hacer un Rombo: ");
            número = Convert.ToInt32(Console.ReadLine());
            for (l = 1; l <= número; l++)
            {
                for (es = 0; es < número - l; es++)
                {
                    Console.Write(" ");
                }
                for (aster = 0; aster < (l * 2) - 1; aster++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (l = número - 2; l >= 0; l--)
            {
                for (es = 1; es < número - l; es++)
                {
                    Console.Write(" ");
                }
                for (aster = 0; aster <= (l * 2); aster++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
