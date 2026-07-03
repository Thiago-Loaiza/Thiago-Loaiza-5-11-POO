using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    /*
     Actividad 2: Posicionamiento de elementos en consola
        Problema:
        Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
         Implementar propiedades y un constructor que cargue valores.
         Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
        nombre en pantalla y Console.CursorVisible para ocultar el cursor.
         Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
        consola.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            ElementoPantalla[] elementos = new ElementoPantalla[4];

            for (int i = 0; i < elementos.Length; i++)
            {
                Console.Clear();

                Console.WriteLine("Elemento " + (i + 1));

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Posicion X: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Posicion Y: ");
                int y = int.Parse(Console.ReadLine());

                elementos[i] = new ElementoPantalla(nombre, x, y);
            }

            Console.Clear();

            for (int i = 0; i < elementos.Length; i++)
            {
                elementos[i].Mostrar();
            }

            Console.SetCursorPosition(0, 20);
            Console.CursorVisible = true;

            Console.ReadKey();
        }
    }
}
