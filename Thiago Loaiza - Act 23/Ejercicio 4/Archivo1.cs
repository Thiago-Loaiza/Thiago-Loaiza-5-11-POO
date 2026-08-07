using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    partial class DispositivoInteligente
    {
        private string nombreDispositivo;
        private double consumoWatts;

        public string NombreDispositivo
        {
            get { return nombreDispositivo; }
            set { nombreDispositivo = value; }
        }

        public double ConsumoWatts
        {
            get { return consumoWatts; }
            set { consumoWatts = value; }
        }

        public DispositivoInteligente(string nombreDispositivo, double consumoWatts)
        {
            this.nombreDispositivo = nombreDispositivo;
            this.consumoWatts = consumoWatts;
        }
    }
}