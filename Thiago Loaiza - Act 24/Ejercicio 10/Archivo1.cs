using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    partial class Ticket
    {
        private string patente;
        private int horasestadia;

        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }

        public int HorasSentandia
        {
            get { return horasestadia; }
            set {  horasestadia = value; }
        }

        public Ticket(string pat, int hors)
        {
            patente = pat;
            horasestadia = hors;
        }
    }
}
