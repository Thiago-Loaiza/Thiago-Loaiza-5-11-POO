using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    partial class Dron
    {
        private string codigo;
        private int niveldebateria;

        public string Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        public int NiveldeBateria
        {
            set 
            {
                niveldebateria = value;
            }
            get { return niveldebateria; }
        }

        public Dron(string codigo, int niveldebateria)
        {
            this.codigo = codigo;
            this.niveldebateria = niveldebateria;
        }
    }
}
