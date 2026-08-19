using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    partial class Plato
    {
        private string nombrePlato;
        private double precio;

        public string NombrePlato
        {
            get { return nombrePlato; }
            set { nombrePlato = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Plato(string nom, double pre)
        {
            nombrePlato = nom;
            precio = pre;
        }
    }
}