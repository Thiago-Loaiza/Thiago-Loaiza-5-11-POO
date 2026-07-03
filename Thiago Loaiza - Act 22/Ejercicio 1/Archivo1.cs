using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    partial class Gimnasio
    {
        private string nombreclase;
        private DateTime horainicio;
        private DateTime horafin;
        public string NombreClase
        {
            get { return nombreclase; }
            set { nombreclase = value; }
        }

        public DateTime HoraInicio
        {
            get { return horainicio; }
            set { horainicio = value; }
        }

        public DateTime HoraFin
        {
            get { return horafin; }
            set { horafin = value; }
        }

        public Gimnasio()
        {
            nombreclase = "Sin nombre";
            horainicio = DateTime.Now;
            horafin = DateTime.Now;
        }
        public Gimnasio(string clase, DateTime hn, DateTime hf)
        {
            this.nombreclase = clase;
            this.horainicio = hn;
            this.horafin = hf;
        }

        public TimeSpan CalculadorTiempo()
        {
            return HoraFin - HoraInicio;
        }
    }
}
