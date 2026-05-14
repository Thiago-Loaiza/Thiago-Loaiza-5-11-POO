using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
    /*
     3. Academia de Gastronomía: Recetario Dinámico
        Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar
        una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
            ● Definir un vector para los nombres de los alumnos.
            ● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato
            presentado.
            ● Métodos:
                1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
                de cada alumno.
                2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
                3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
                4. Calcular el puntaje promedio de cada alumno e informar si está &quot;Aprobado&quot;
                (promedio &gt;= 70) o &quot;Reprobado&quot;.
                5. Determinar quién obtuvo el puntaje individual más alto en un solo plato (el
                valor máximo de la matriz).
     */
    internal class Gastronomia
    {
        string[] alumnos;
        int[][] platos;

        public void Carga()
        {
            alumnos = new string[3];
            platos = new int[3][];

            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno");
                alumnos[i] = Console.ReadLine();

                Console.WriteLine("Ingrese la cantidad de platos del alumno");
                int cantidad = int.Parse(Console.ReadLine());

                platos[i] = new int[cantidad];
            }

            Console.WriteLine("");
        }

        public void CargarPuntajes()
        {
            int puntaje;

            for (int f = 0; f < platos.Length; f++)
            {
                for (int c = 0; c < platos[f].Length; c++)
                {
                    do
                    {
                        Console.WriteLine("Ingrese el puntaje del plato " + (c + 1) + " del alumno " + alumnos[f]);
                        puntaje = int.Parse(Console.ReadLine());

                    } while (puntaje < 0 || puntaje > 100);

                    platos[f][c] = puntaje;
                }
            }

            Console.WriteLine("");
        }

        public void Mostrar()
        {
            for (int f = 0; f < platos.Length; f++)
            {
                Console.WriteLine("Alumno : " + alumnos[f]);

                for (int c = 0; c < platos[f].Length; c++)
                {
                    Console.Write(platos[f][c] + " - ");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("");
        }

        public void PromedioAlumno()
        {
            int suma = 0;

            for (int f = 0; f < platos.Length; f++)
            {
                for (int c = 0; c < platos[f].Length; c++)
                {
                    suma = suma + platos[f][c];
                }

                double promedio = (double)suma / platos[f].Length;

                if (promedio >= 70)
                {
                    Console.WriteLine(alumnos[f] + " aprobado con promedio : " + promedio);
                }
                else
                {
                    Console.WriteLine(alumnos[f] + " reprobado con promedio : " + promedio);
                }

                suma = 0;
            }

            Console.WriteLine("");
        }

        public void MejorPlato()
        {
            int mayor = platos[0][0];
            string alumno = alumnos[0];

            for (int f = 0; f < platos.Length; f++)
            {
                for (int c = 0; c < platos[f].Length; c++)
                {
                    if (platos[f][c] > mayor)
                    {
                        mayor = platos[f][c];
                        alumno = alumnos[f];
                    }
                }
            }

            Console.WriteLine("El puntaje mas alto fue : " + mayor);
            Console.WriteLine("Pertenece al alumno : " + alumno);
        }

        static void Main(string[] args)
        {
            Gastronomia g = new Gastronomia();

            g.Carga();
            g.CargarPuntajes();
            g.Mostrar();
            g.PromedioAlumno();
            g.MejorPlato();

            Console.ReadKey();
        }
    }
}