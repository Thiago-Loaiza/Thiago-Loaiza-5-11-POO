using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    partial class Libro
    {
        public void Resumen()
        {
            Console.WriteLine("El titulo de este libro es : " + Titulo);
            Console.WriteLine("Hecho por : " + Autor);
            if (CantidadPaginas < 100) 
            {
                Console.WriteLine("El libro es corto para leer");
            }
            else
            {
                Console.WriteLine("El libro es largo para leer");
            }
        }
    }
}
