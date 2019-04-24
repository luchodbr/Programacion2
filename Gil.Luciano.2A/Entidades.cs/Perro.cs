using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.cs
{
    public class Perro : Mascota
    {
        private int _edad;
        private bool _esAlfa;

        public Perro(string nombre, string raza) : base(nombre,raza)
        {
            this._edad = 0;
            this._esAlfa = false;
        }
        public Perro(string nombre, string raza, int edad, bool alfa) : this(nombre, raza)
        {
            this._edad = edad;
            this._esAlfa = alfa;
        }
        protected override string Ficha()
        {
            if (this._esAlfa == true)
            {
                return this.Nombre + " " + this.Raza + ", alfa de la manada " + this._edad.ToString(); 
            }
            else
            {
                return this.Nombre + " " + this.Raza + " " + this._edad.ToString();
            }

        }

        #region //SOBRECARGA DE OPERADORES

        public static bool operator ==(Perro p1, Perro p2)
        {
            bool retorno = false;
            if(p1._edad == p2._edad && p1.Nombre == p2.Nombre && p1.Raza == p2.Raza)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Perro p1, Perro p2)
        {
            if (p1 == p2)
                return false;
            return true;
        }
        public override string ToString()
        {
            return this.Ficha() ;
        }

        public static explicit operator int(Perro p1)
        {
            return p1._edad;
        }
        public override bool Equals(object obj)
        {
            if (obj is Perro)
            {
                if ((Perro)obj == this)
                    return true;
            }
            return false;
        }
        #endregion
    }
}
