using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase05Entidades
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantitad;

        //Constructor
        public Pluma() : this("sin marca", null, 0)
        {
        }
        public Pluma(string marca) : this(marca, null, 0)
        {
        }
        public Pluma(string marca, Tinta tinta) : this(marca, tinta, 0)
        {
        }
        public Pluma(string marca, Tinta tinta, int cantidad)
        {
            this._marca = marca;
            this._tinta = tinta;
            this._cantitad = cantidad;
        }

        private string Mostrar()
        {
            return this._marca.ToString() + " " + Tinta.Mostrar(this._tinta) + " " + this._cantitad.ToString();
        }

        public static bool operator ==(Pluma dato1, Tinta dato2)
        {
            return dato1._tinta == dato2;
            //bool rta = false;
            //if (dato1._tinta == dato2)
            //    rta = true;
            //else
            //    rta = false;
            //return rta;
        }
        public static bool operator !=(Pluma dato1, Tinta dato2)
        {
            return !(dato1 == dato2);
        }

        //public static implicit/explicit
        public static implicit operator string(Pluma mypluma)
        {
            return mypluma.Mostrar();

        }
        public static Pluma operator +(Pluma p1,Tinta t1)
        {
            if (p1 == t1 && p1._cantitad <= 90)
                p1._cantitad += 10;
            return p1;

            
                
        }
    }
}
