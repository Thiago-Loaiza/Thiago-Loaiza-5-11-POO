using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    partial class Vuelo
    {
        private string codigo;
        private DateTime horaSalida;
        private DateTime horaLlegada;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public DateTime HoraSalida
        {
            get { return horaSalida; }
            set { horaSalida = value; }
        }

        public DateTime HoraLlegada
        {
            get { return horaLlegada; }
            set { horaLlegada = value; }
        }

        public Vuelo()
        {
            codigo = "Sin codigo";
            horaSalida = DateTime.Now;
            horaLlegada = DateTime.Now;
        }

        public Vuelo(string codigo, DateTime horaSalida, DateTime horaLlegada)
        {
            this.codigo = codigo;
            this.horaSalida = horaSalida;
            this.horaLlegada = horaLlegada;
        }

        public TimeSpan CalcularDuracion()
        {
            return HoraLlegada - HoraSalida;
        }
    }
}
