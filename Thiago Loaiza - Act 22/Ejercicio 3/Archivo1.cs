using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    partial class Entrenamiento
    {
        private string deportista;
        private int duracion;

        public string Deportista
        {
            get { return deportista; }
            set { deportista = value; }
        }

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public Entrenamiento()
        {
            deportista = "Sin nombre";
            duracion = 0;
        }

        public Entrenamiento(string deportista)
        {
            this.deportista = deportista;
            duracion = 0;
        }
        public void RegistrarDuracion(int minutos)
        {
            duracion = minutos;
        }
        public void RegistrarDuracion(int horas, int minutos)
        {
            duracion = (horas * 60) + minutos;
        }
    }
}
