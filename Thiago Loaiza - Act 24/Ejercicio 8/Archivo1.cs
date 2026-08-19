using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    partial class Medicamento
    {
        private string nombre;
        private int stock;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public Medicamento(string nom, int stk)
        {
            nombre = nom;
            stock = stk;
        }
    }
}