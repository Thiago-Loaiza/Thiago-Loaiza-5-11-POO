using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    /*
     Actividad 4: Gestión de vuelos
        Problema:

        Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada (DateTime).
         Usar la palabra clave this en el constructor para diferenciar los parámetros de
        los atributos.
         Crear un método para calcular la duración del vuelo (TimeSpan).
         Cargar un vector con 4 vuelos y mostrar:
        1. El código y duración del vuelo más largo.
        2. El código del vuelo que salga más temprano.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Vuelo[] vuelos = new Vuelo[4];

            for (int i = 0; i < vuelos.Length; i++)
            {
                Console.WriteLine("Vuelo " + (i + 1));

                Console.Write("Ingrese el codigo: ");
                string codigo = Console.ReadLine();

                Console.Write("Ingrese la hora de salida (horas:minutos): ");
                DateTime salida = DateTime.Parse(Console.ReadLine());

                Console.Write("Ingrese la hora de llegada (horas:minutos): ");
                DateTime llegada = DateTime.Parse(Console.ReadLine());

                vuelos[i] = new Vuelo(codigo, salida, llegada);

                Console.WriteLine();
            }

            Vuelo vueloMayor = vuelos[0];
            TimeSpan mayorDuracion = vuelos[0].CalcularDuracion();

            for (int i = 1; i < vuelos.Length; i++)
            {
                if (vuelos[i].CalcularDuracion() > mayorDuracion)
                {
                    mayorDuracion = vuelos[i].CalcularDuracion();
                    vueloMayor = vuelos[i];
                }
            }

            Console.WriteLine("El vuelo mas largo es: " + vueloMayor.Codigo);
            Console.WriteLine("Duracion: " + mayorDuracion);

            Console.WriteLine();

            Vuelo vueloTemprano = vuelos[0];

            for (int i = 1; i < vuelos.Length; i++)
            {
                if (vuelos[i].HoraSalida < vueloTemprano.HoraSalida)
                {
                    vueloTemprano = vuelos[i];
                }
            }

            Console.WriteLine("El vuelo que sale mas temprano es: " + vueloTemprano.Codigo);
            Console.WriteLine("Hora de salida: " + vueloTemprano.HoraSalida);

            Console.ReadKey();
        }
    }
}
