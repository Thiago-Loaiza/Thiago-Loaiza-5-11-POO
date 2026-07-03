using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    partial class Carrera
    {
        private string codigo;
        private DateTime horaInicio;
        private DateTime horaFin;
        private List<Corredor> corredores;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public DateTime HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }

        public DateTime HoraFin
        {
            get { return horaFin; }
            set { horaFin = value; }
        }

        public List<Corredor> Corredores
        {
            get { return corredores; }
            set { corredores = value; }
        }

        public Carrera()
        {
            codigo = "Sin codigo";
            horaInicio = DateTime.Now;
            horaFin = DateTime.Now;
            corredores = new List<Corredor>();
        }

        public Carrera(string codigo, DateTime horaInicio, DateTime horaFin)
        {
            this.codigo = codigo;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            corredores = new List<Corredor>();
        }

        public TimeSpan CalcularDuracion()
        {
            return HoraFin - HoraInicio;
        }
    }
}
