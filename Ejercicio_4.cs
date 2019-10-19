using System;

namespace Programa_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, horasextras, resp;
            double salario, salarioextra, salariototal;

            do
            {
                Console.WriteLine("Ingrese las horas trabajadas: ");
                horas = int.Parse(Console.ReadLine());
                if (horas <= 35)
                {
                    salario = horas * 15;
                }
                else
                {
                    horasextras = horas - 35;
                    salarioextra = horasextras * 22;
                    salariototal = 35 * 15;
                    salario = salarioextra + salariototal;
                }
                Console.WriteLine("El salario total para su personal es: " + salario);
                Console.WriteLine("¿Desea calcular el salario de otra persona ? " +
                    "SI entonces digite 1 / Si NO digite 0");
                resp = int.Parse(Console.ReadLine());

            } while (resp == 1);
            Console.WriteLine("Su salario se ha calculado exitosamente ");
            Console.ReadLine();
        }
    }
}
