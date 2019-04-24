using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.cs
{
    public abstract class Mascota
    {

        private string _nombre;
        private string _raza;
        public string Nombre { get { return _nombre; } }
        public string Raza { get { return _raza; } }
        protected virtual string DatosCompletos()
        {
            return this._nombre + " " + this._raza;
        }
        protected abstract string Ficha();

        //constructor
        public Mascota(string nombre, string raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }
       
    }
}
