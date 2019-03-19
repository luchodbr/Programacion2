using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            // int numero1;
            //int numero2;
            // int numero3;
            Console.WriteLine("Ingrese un nombre");
            string valor = Console.ReadLine();
            Console.WriteLine("El nombre es: {0}" ,valor);
            //int.TryParse(valor, out int valorInt);
            //Console.WriteLine("{0}", valorInt);

            Console.ReadKey();
        }
    }
}
