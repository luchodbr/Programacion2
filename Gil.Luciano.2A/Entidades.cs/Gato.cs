using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.cs
{
    public class Gato : Mascota
    {
        protected override string Ficha()
        {
            return this.Nombre + this.Raza;
        }
        public Gato(string nombre, string raza) : base(nombre, raza)
        {
        }
        #region //SOBRECARGA DE OPERADORES

        public static bool operator ==(Gato g1, Gato g2)
        {
            bool retorno = false;
            if (g1.Nombre == g2.Nombre && g1.Raza == g2.Raza)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Gato g1, Gato g2)
        {
            if (g1 == g2)
                return false;
            return true;
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        public override bool Equals(object obj)
        {
            if (obj is Gato)
            {
                if ((Gato)obj == this)
                    return true;
            }
            return false;
        }



        #endregion
    }
}
