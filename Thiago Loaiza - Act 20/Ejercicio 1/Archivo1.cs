using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    partial class Vuelo
    {
        protected int numerovuelo;
        protected string destino;
        protected int duracionhoras;

        public int NumeroVuelo
        {
            set { numerovuelo = value; }
            get { return numerovuelo; }
        }

        public string Destino
        {
            set { destino = value; }
            get { return destino; }
        }

        public int DuracionHoras
        {
            set { duracionhoras = value; }
            get{ return duracionhoras; }
        }

        public Vuelo(int numvuelo,string dest, int durahoras)
        {
            numerovuelo=numvuelo;
            destino=dest;
            duracionhoras=durahoras;

            Console.WriteLine("CONSTRUCTOR DE VUELO");
            Console.WriteLine("===============");
        }
    }
}
