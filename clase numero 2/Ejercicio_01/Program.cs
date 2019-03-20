using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroMax = int.MinValue;
            int numeroMin = int.MaxValue;
            float numeroAcum = 0;
            float numeroProm;
            int i = 0;
            Console.Title = "ejercicio nro 01";
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el numero");
                string numeroString = Console.ReadLine();
                if (int.TryParse(numeroString, out int numeroEntero) == true)
                {
                    if (numeroEntero > numeroMax)
                        numeroMax = numeroEntero;
                    if (numeroEntero < numeroMin)
                        numeroMin = numeroEntero;
                    numeroAcum = numeroAcum + numeroEntero;
                }
                else
                {
                    Console.WriteLine("El numero ingresado es incorrecto");
                    Console.ReadKey();
                    Console.Error.WriteLine("\nError information written");
                }
            }
            numeroProm = numeroAcum / i;
                Console.Write("el max es {0}  el min es  {1}  acum es {2} y el promedio es {3}", numeroMax, numeroMin, numeroAcum ,numeroProm);
            Console.ReadKey();
        }

    }

}