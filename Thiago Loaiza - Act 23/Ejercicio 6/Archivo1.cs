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
        private int anioPublicacion;

        public string Titulo
        {
            get { return titulo; }
        }

        public int AnioPublicacion
        {
            get { return anioPublicacion; }
        }

        public Libro(string titulo, int anioPublicacion)
        {
            this.titulo = titulo;
            this.anioPublicacion = anioPublicacion;
        }
    }
}