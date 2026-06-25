using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    partial class Paquete
    {
        private int codigo;
        private float peso;
        private string destino;

        public int Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }

        public float Peso
        {
            set {  peso = value; }
            get{ return peso; }
        }

        public string Destino
        {
            set { destino = value; }
            get { return destino; }
        }
    }
}
