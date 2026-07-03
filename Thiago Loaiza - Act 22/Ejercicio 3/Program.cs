using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    /*
     Actividad 3: Registro de entrenamientos
        Problema:
        Plantear una clase Entrenamiento con atributos: deportista y duración (en minutos).
         Incluir dos métodos RegistrarDuracion (sobrecarga de métodos):
        1. Uno que reciba horas y minutos y los convierta a minutos.
        2. Otro que reciba directamente los minutos.
         Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
        más corto.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Entrenamiento> entrenamientos = new List<Entrenamiento>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Entrenamiento " + (i + 1));

                Console.Write("Nombre del deportista: ");
                string nombre = Console.ReadLine();

                Entrenamiento e = new Entrenamiento(nombre);

                Console.WriteLine("¿Como desea ingresar la duracion?");
                Console.WriteLine("1 para poner -> En minutos");
                Console.WriteLine("2 para poner -> En horas y minutos");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Minutos: ");
                    int minutos = int.Parse(Console.ReadLine());

                    e.RegistrarDuracion(minutos);
                }
                else
                {
                    Console.Write("Horas: ");
                    int horas = int.Parse(Console.ReadLine());

                    Console.Write("Minutos: ");
                    int minutos = int.Parse(Console.ReadLine());

                    e.RegistrarDuracion(horas, minutos);
                }

                entrenamientos.Add(e);

                Console.WriteLine();
            }

            Entrenamiento mayor = entrenamientos[0];
            Entrenamiento menor = entrenamientos[0];

            for (int i = 1; i < entrenamientos.Count; i++)
            {
                if (entrenamientos[i].Duracion > mayor.Duracion)
                {
                    mayor = entrenamientos[i];
                }

                if (entrenamientos[i].Duracion < menor.Duracion)
                {
                    menor = entrenamientos[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Entrenamiento mas largo");
            Console.WriteLine("Deportista: " + mayor.Deportista);
            Console.WriteLine("Duración: " + mayor.Duracion + " minutos");

            Console.WriteLine();

            Console.WriteLine("Entrenamiento más corto");
            Console.WriteLine("Deportista: " + menor.Deportista);
            Console.WriteLine("Duración: " + menor.Duracion + " minutos");

            Console.ReadKey();
        }
    }
}
