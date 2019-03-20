using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.mensaje);
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;
            ArmarFormatoMensaje();
            Console.WriteLine(ArmarFormatoMensaje());
            Console.ReadKey();
        }
        private static string ArmarFormatoMensaje()
        {
            int mensajeLargo = Sello.mensaje.Length;
            string techo = "";
          
            for(int i=0; i < mensajeLargo+2; i++ )
            {
                techo += "*";
            }
            techo += "\n";

            Sello.mensaje = "*" + Sello.mensaje + "*\n";
            string mensajeDef = "";
            mensajeDef = (techo + mensaje + techo);
            Sello.mensaje = mensajeDef;
            Console.WriteLine(mensajeDef);
            return mensajeDef;
     
        }
    }
}
