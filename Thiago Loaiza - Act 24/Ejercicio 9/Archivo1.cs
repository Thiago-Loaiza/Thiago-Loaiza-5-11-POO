using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    partial class Estudiante
    {
        private string nombreCompleto;
        private double calificacion;

        public string NombreCompleto
        {
            get { return nombreCompleto; }
        }

        public double Calificacion
        {
            get { return calificacion; }
        }

        public Estudiante(string nom, double cal)
        {
            nombreCompleto = nom;
            calificacion = cal;
        }
    }
}
