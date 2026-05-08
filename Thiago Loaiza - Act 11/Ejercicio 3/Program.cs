using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    /*
    3. Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
    empresa.

    Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
    irregular para cargar los días que han faltado cada empleado (cargar el número de día que
    faltó)

    Cada fila de la matriz representa los días de cada empleado.

    a. Mostrar los empleados con la cantidad de inasistencias.
    b. Cuál empleado faltó menos días.
    */

    internal class AdministraAusentes
    {
        private string[] empleados;
        private int[][] faltas;

        public void Carga()
        {
            empleados = new string[3];
            faltas = new int[3][];

            for (int f = 0; f < empleados.Length; f++)
            {
                Console.WriteLine("Ingrese el nombre del empleado");
                empleados[f] = Console.ReadLine();

                Console.WriteLine("Cuantos dias falto " + empleados[f] + "?");
                string linea;
                linea = Console.ReadLine();
                int cantidad = int.Parse(linea);

                faltas[f] = new int[cantidad];

                for (int c = 0; c < faltas[f].Length; c++)
                {
                    Console.WriteLine("Ingrese el dia que falto");
                    linea = Console.ReadLine();
                    faltas[f][c] = int.Parse(linea);
                }
            }

            Console.WriteLine(" --- ");
        }

        public void Imprimir()
        {
            for (int f = 0; f < empleados.Length; f++)
            {
                Console.WriteLine("Empleado: " + empleados[f]);

                Console.WriteLine("Dias que falto:");

                for (int c = 0; c < faltas[f].Length; c++)
                {
                    Console.WriteLine(" - " + faltas[f][c]);
                }

                Console.WriteLine("Cantidad de inasistencias: " + faltas[f].Length);

                Console.WriteLine();
            }
        }

        public void MenosFaltas()
        {
            int menor = faltas[0].Length;
            string nombre = empleados[0];

            for (int f = 0; f < empleados.Length; f++)
            {
                if (faltas[f].Length < menor)
                {
                    menor = faltas[f].Length;
                    nombre = empleados[f];
                }
            }

            Console.WriteLine("El empleado que menos falto es: " + nombre);
            Console.WriteLine("Cantidad de faltas: " + menor);
        }
        static void Main(string[] args)
        {
            AdministraAusentes aa = new AdministraAusentes();

            aa.Carga();
            aa.Imprimir();
            aa.MenosFaltas();

            Console.ReadKey();
        }
    }
}
