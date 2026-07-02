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
            set { nombreclase = value; }
            get { return nombreclase; }
        }

        public DateTime HoraInicio
        {
            set {  horainicio = value; }
            get { return horainicio; }
        }

        public DateTime HoraFin
        {
            set { horafin = value; }
            get { return horafin; }
        }

        public Gimnasio()
        {
            nombreclase = "Sin Nombre";
            horainicio = new DateTime(1,1,1,1,1,1);
            horafin = new DateTime(1,1,1,1,1,1);
        }

        public Gimnasio(string clase, DateTime hn, DateTime hf)
        {
            nombreclase = clase;
            horainicio = hn;
            horafin = hf;
        }

        public TimeSpan CalculadorTiempo()
        {
            TimeSpan duracion;

            duracion = HoraInicio - HoraFin;
            Console.WriteLine("La duracion de la clase " + NombreClase + " es de: " + duracion);
            return duracion;
        }
    }
}
