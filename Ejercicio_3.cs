using System;

namespace Programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            { 
            int numero;
            double precio;
            double total = 0;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese la cantidad vendida del producto: ");
                    numero = Convert.ToInt16(Console.ReadLine());
                    if (numero < 0) Console.WriteLine("Cantidad no valida");
                } while (numero < 0);
                if (numero > 0)
                {
                    Console.WriteLine("Ingrese el precio unitario del producto: ");
                    do
                    {
                        precio = Convert.ToDouble(Console.ReadLine());
                        if (precio < 0) Console.WriteLine("Precio no valido");
                        else total += numero * precio;
                    } while (precio < 0);
                }
            } while (numero != 0);

            Console.WriteLine("Total vendido = " + total);
            Console.WriteLine();
        }
        Console.ReadKey();
        }
    }
}
