using System;

namespace Programa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad, numero, mayor = 0;
            Console.Write("El número máximo es: ");

            cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Escribe un Número:");


                numero = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    mayor = numero;
                }
                else if (i == 0)
                {
                }
                if (numero > mayor)
                {
                    mayor = numero;
                }


            }
            Console.WriteLine("El número mayor es: " + mayor);
            Console.ReadKey();
        }
    }
}
