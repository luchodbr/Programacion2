using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase05Entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipoTinta;

        public Tinta():this(ETipoTinta.Comun, ConsoleColor.Black)
        {           
        }
        public Tinta(ConsoleColor color):this(ETipoTinta.Comun,color)
        {           
        }
       
        public Tinta(ETipoTinta tipoTinta, ConsoleColor color)
        {
            this._color = color;           
            this._tipoTinta = tipoTinta;
        }

        //metodos

        private string Mostrar()
        {
           return this._color.ToString() +"  " + this._tipoTinta.ToString();          
        }
        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        //sobrecarga de operador
        public static bool operator ==(Tinta dato1, Tinta dato2)
        {
            bool rta = false;
            if (dato1._color == dato2._color && dato1._tipoTinta == dato2._tipoTinta)
                rta = true;
            else
                rta = false;
            return rta;
        }
        public static bool operator !=(Tinta dato1, Tinta dato2)
        {
            return !(dato1 == dato2);
        }
    }
}
