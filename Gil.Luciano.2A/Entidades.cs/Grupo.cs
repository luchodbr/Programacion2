using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.cs
{
    public class Grupo
    {
        private List<Mascota> _manada;
        private static ETipoManada _tipo;
        public static ETipoManada Tipo { set { _tipo = value; } }
        private string _nombre;

        private Grupo()
        {
            this._manada = new List<Mascota>();
        }
          static Grupo() 
        {
            Grupo._tipo = ETipoManada.Unica;
        }
        public Grupo(string nombre): this()
        {
            this._nombre = nombre;
        }
        public Grupo(string nombre, ETipoManada tip) : this(nombre)
        {
            Tipo = tip;
        }

        //oper
        public static bool operator ==(Mascota m, Grupo g)
        {
            bool retorno = false;
            foreach (Mascota mas in g._manada)
            {
                if (m == mas)
                    retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Mascota m, Grupo g)
        {
            return !(m == g);
        }
        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (m != g)
            {
                g._manada.Add(m);
            }
            else
                Console.Write(" Ya se encuentra la mascota ");
                return g;
        }
        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (m == g)
            {
                g._manada.Remove(m);
            }
            else
                Console.Write("no se encuentra la mascota");
            return g;
        }
        public static implicit operator string(Grupo g)
        {
            string retorno = " ";
            retorno += "Grupo " + g._nombre + " - " + "Tipo " + Grupo._tipo +"\n " ;
            retorno += "Integrantes " +  g._manada.Count + ">:\n";
            foreach (Mascota m in g._manada)
            {
                retorno += m.ToString() + "\n";
            }
            return retorno;
        }
    }

   
}
