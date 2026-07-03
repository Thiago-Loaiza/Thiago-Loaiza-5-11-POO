using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    partial class Corredor
    {
        private string nombre;
        private int dorsal;
        private int tiempoTotal;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Dorsal
        {
            get { return dorsal; }
            set { dorsal = value; }
        }

        public int TiempoTotal
        {
            get { return tiempoTotal; }
            set { tiempoTotal = value; }
        }

        public Corredor()
        {
            nombre = "Sin nombre";
            dorsal = 0;
            tiempoTotal = 0;
        }

        public Corredor(string nombre, int dorsal)
        {
            this.nombre = nombre;
            this.dorsal = dorsal;
            tiempoTotal = 0;
        }

        public void RegistrarTiempo(int minutos)
        {
            tiempoTotal = minutos;
        }

        public void RegistrarTiempo(int horas, int minutos)
        {
            tiempoTotal = horas * 60 + minutos;
        }
    }
}
