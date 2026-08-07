using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    partial class Libro
    {
        private string titulo;
        private int añoPublicacion;

        public string Titulo
        {
            get { return titulo; }
        }

        public int AñoPublicacion
        {
            get { return añoPublicacion; }
        }

        public Libro(string titulo, int anioPublicacion)
        {
            this.titulo = titulo;
            this.añoPublicacion = anioPublicacion;
        }
    }
}