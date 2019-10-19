using System;

namespace Programa_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int número, l, es, aster;
            Console.WriteLine("Digite numero para crear la piramide: ");
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
            Console.ReadKey();
        }
    }
}
