using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    /*
     2. Crear una clase parcial Libro.
        En el primer archivo, declarar las propiedades Título, Autor y Páginas. Validar que la
        cantidad de páginas sea mayor a 10. Valores cargados desde consola
        En el segundo archivo, agregar un método Resumen() que muestre el título, autor y
        si el libro es corto (menos de 100 páginas) o largo.
        Desde la clase principal, cargar 2 libros y mostrar cuál es el más extenso.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro();
            Libro libro2 = new Libro();
            string NombreMay;
            int CantMay = 0;
            libro1.Resumen();
            Console.WriteLine("");
            libro2.Resumen();
            Console.WriteLine("");
            if (libro1.CantidadPaginas > libro2.CantidadPaginas)
            {
                CantMay = libro1.CantidadPaginas;
                NombreMay = libro1.Titulo;
            }
            else
            {
                CantMay = libro2.CantidadPaginas;
                NombreMay = libro2.Titulo;
            }
            Console.WriteLine("El libro con mayor cantidad de pagina es: " + NombreMay + " Con una cantidad de: " + CantMay);
        }
    }
}
