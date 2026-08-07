using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    /*
     6-
        Una biblioteca pública gestiona de forma digital su catálogo de obras literarias
        para organizar la consulta de ejemplares por parte de los lectores.
         Crear la clase Libro que contenga como atributos privados: titulo
        (string) y anioPublicacion (int). Definir sus propiedades de solo lectura y
        un constructor que reciba tit y anio.
         Crear la clase BibliotecaCentral que administre una lista de objetos
        List.
         Métodos en BibliotecaCentral:
        1. CargarCatalogo(): Solicitar por teclado títulos y años de
        publicación para agregar libros a la lista mediante .Add(). La carga
        finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como título.
        2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo
        junto a la cantidad total de obras registradas mediante la propiedad
        .Count.
        3. FiltrarPorAnio(): Solicitar al usuario un año determinado e
        imprimir en consola únicamente aquellos libros cuyo año de
        publicación sea menor a dicho valor.
        4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando
        los métodos de búsqueda y remoción de listas, eliminarlo de la
        colección si se encuentra presente.
     */
    internal class BibliotecaCentral
    {
        List<Libro> catalogo = new List<Libro>();

        public void CargarCatalogo()
        {
            Console.WriteLine("=== CARGA DE LIBROS ===");
            Console.WriteLine();

            Console.WriteLine("Ingrese el titulo del libro (FIN para terminar)");
            string titulo = Console.ReadLine();

            while (titulo != "FIN")
            {
                Console.WriteLine("Ingrese el año de publicacion");
                int año = int.Parse(Console.ReadLine());

                while(año < 0)
                {
                    Console.WriteLine("Reingresa el año, no puede ser negativo");
                    año = int.Parse(Console.ReadLine());
                }

                Libro obj = new Libro(titulo, año);

                catalogo.Add(obj);

                Console.WriteLine();
                Console.WriteLine("Ingrese el titulo del libro (FIN para terminar)");
                titulo = Console.ReadLine();
            }
        }

        public void ListarCatalogo()
        {
            Console.WriteLine();
            Console.WriteLine("=== CATALOGO ===");
            Console.WriteLine();

            foreach (Libro l in catalogo)
            {
                Console.WriteLine("Titulo: " + l.Titulo +
                    " | Año: " + l.AñoPublicacion);
            }

            Console.WriteLine();
            Console.WriteLine("Cantidad de libros: " + catalogo.Count);
        }

        public void FiltrarPorAnio()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese un año");

            int año = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Libros publicados antes de " + año);

            foreach (Libro l in catalogo)
            {
                if (l.AñoPublicacion < año)
                {
                    Console.WriteLine("Titulo: " + l.Titulo +
                        " | Año: " + l.AñoPublicacion);
                }
            }
        }

        public void RemoverLibro()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese el titulo del libro a eliminar");

            string titulo = Console.ReadLine();

            int encontrado = 0;

            for (int i = 0; i < catalogo.Count; i++)
            {
                if (catalogo[i].Titulo == titulo)
                {
                    catalogo.RemoveAt(i);

                    Console.WriteLine("Libro eliminado.");

                    encontrado++;

                    break;
                }
            }

            if (encontrado == 0)
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }

        static void Main(string[] args)
        {
            BibliotecaCentral bc = new BibliotecaCentral();

            bc.CargarCatalogo();
            Console.WriteLine();
            bc.ListarCatalogo();
            Console.WriteLine();
            bc.FiltrarPorAnio();
            Console.WriteLine();
            bc.RemoverLibro();
            Console.WriteLine();
            bc.ListarCatalogo();

            Console.ReadKey();
        }
    }
}