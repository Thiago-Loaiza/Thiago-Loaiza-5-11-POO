using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    partial class Documento
    {
        private string nombreArchivo;
        private int cantidadPaginas;

        public string NombreArchivo
        {
            set { nombreArchivo = value; }
            get { return nombreArchivo; }
        }

        public int CantidaPaginas
        {
            set { cantidadPaginas = value; }
            get { return cantidadPaginas; }
        }

        public Documento(string nombreArchivo, int cantidadPaginas)
        {
            NombreArchivo = nombreArchivo;
            CantidaPaginas = cantidadPaginas;
        }
    }
}
