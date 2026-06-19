using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    partial class Libro
    {
        private string titulo;
        private string autor;
        private int cantidadpaginas;

        public string Titulo
        {
            set {  titulo = value; }
            get { return titulo; }
        }

        public string Autor
        {
            set { autor = value; }
            get { return autor; }
        }

        public int CantidadPaginas
        {
            set { cantidadpaginas = value; }
            get{ return cantidadpaginas; }
        }

        public Libro()
        {
            Console.WriteLine("Informacion del libro");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el Titulo del libro");
            Titulo = Console.ReadLine();
            Console.WriteLine("Ingrese el Autor de este libro");
            Autor = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de paginas que tiene este libro");
            CantidadPaginas = int.Parse(Console.ReadLine());
            while (CantidadPaginas < 10)
            {
                Console.WriteLine("La cantidad de paginas tiene que ser mayor a 10");
                CantidadPaginas = int.Parse(Console.ReadLine());
            }
        }
    }
}
