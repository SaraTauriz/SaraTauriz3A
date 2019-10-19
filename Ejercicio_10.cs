using System;

namespace Programa_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int número, num1, num2, suma;
            do
            {
                Console.WriteLine("Elegir una opción\n" +
                    "\n 1) Salir" +
                    "\n 2) Sumatorio" +
                    "\n 3) Factorial");

                número = Convert.ToInt32(Console.ReadLine());

                switch (número)
                {
                    case 1:
                        Console.WriteLine("Salir");
                        break;

                    case 2:

                        Console.WriteLine("Ingrese primer número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        num2 = int.Parse(Console.ReadLine());

                        suma = num1 + num2;
                        Console.WriteLine("El resultado es:" + suma);
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Introduzca el número:");
                        int fact, Factorial = 1, Contador = 0;
                        fact = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= fact; i++)
                        {
                            Contador = Contador + 1;
                            Factorial = Factorial * Contador;

                        }
                        Console.WriteLine("El Factorial de el número es igual a :" + Factorial);
                        Console.WriteLine();
                        break;
                }
            } while (número != 1);
            Console.ReadKey();
        }
    }
}
