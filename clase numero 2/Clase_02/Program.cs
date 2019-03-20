using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "hola";
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
            //Sello.color = ConsoleColor.Blue;
            //Sello.ImprimirEnColor();
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();

        }
    }
}
