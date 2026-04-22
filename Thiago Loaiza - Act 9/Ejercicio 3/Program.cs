using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    /*
     3. Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
        carrera de 100 metros. El programa debe cargar los datos en dos vectores
        paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
        atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
        promedio.
     */
    internal class Program
    {
        static string[] nombres;
        static int[] tiempos;

        static void Cargar()
        {
            nombres = new string[5];
            tiempos = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Tiempo: ");
                tiempos[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Procesar()
        {
            float suma = 0;

            for (int i = 0; i < 5; i++)
            {
                suma = suma + tiempos[i];
            }

            float promedio = suma / 5;
            Console.WriteLine("Promedio : " + promedio);

            int mejor = tiempos[0];
            int peor = tiempos[0];

            for (int i = 1; i < 5; i++)
            {
                if (tiempos[i] < mejor)
                {
                    mejor = tiempos[i];
                }

                if (tiempos[i] > peor)
                {
                    peor = tiempos[i];
                }
            }

            Console.WriteLine("Mejor tiempo:");
            for (int i = 0; i < 5; i++)
            {
                if (tiempos[i] == mejor)
                {
                    Console.WriteLine(nombres[i] + " - " + tiempos[i]);
                }
            }

            Console.WriteLine("Peor tiempo: ");
            for (int i = 0; i < 5; i++)
            {
                if (tiempos[i] == peor)
                {
                    Console.WriteLine(nombres[i] + " - " + tiempos[i]);
                }
            }

            Console.WriteLine("Superaron el promedio:");
            for (int i = 0; i < 5; i++)
            {
                if (tiempos[i] < promedio)
                {
                    Console.WriteLine(nombres[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Cargar();
            Procesar();
            Console.ReadKey();
        }
    }
}
