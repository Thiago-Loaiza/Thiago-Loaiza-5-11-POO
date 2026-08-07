using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    partial class Vehiculo
    {
        private string patente;
        private double costoReparacion;

        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }

        public double CostoReparacion
        {
            get { return costoReparacion; }
            set { costoReparacion = value; }
        }

        public Vehiculo(string patente, double costoReparacion)
        {
            this.patente = patente;
            this.costoReparacion = costoReparacion;
        }
    }
}