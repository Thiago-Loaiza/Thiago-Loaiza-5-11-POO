using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    partial class VueloInternacional : Vuelo
    {
        private string paisdestino;

        public string PaisDestino
        {
            set { paisdestino = value; }
            get { return paisdestino; }
        }

        public VueloInternacional(int numvuelo, string dest, int durahoras, string paisdest) : base(numvuelo,dest,durahoras)
        {
            paisdestino = paisdest;
            Console.WriteLine("CONSTRUCTOR DE VUELO INTERNACIONAL");
            Console.WriteLine("===============");
        }
    }
}
