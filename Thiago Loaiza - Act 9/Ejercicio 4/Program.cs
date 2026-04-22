using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    /*
     4. Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
        sus nombres y puntajes promedio obtenidos (de 1 a 10).
        Cargar sus datos en vectores paralelos, mostrar docente con calificación más
        alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
        calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
        desaprobaron (tomando como base que se aprueba con una nota mayor o igual
        a 6)
     */
    internal class Program
    {
        static string[] nombres;
        static int[] notas;

        static void Cargar()
        {
            nombres = new string[6];
            notas = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Nota: ");
                notas[i] = int.Parse(Console.ReadLine());
            }
        }

        static void MayorMenor()
        {
            int mayor = notas[0];
            int menor = notas[0];

            for (int i = 1; i < 6; i++)
            {
                if (notas[i] > mayor)
                {
                    mayor = notas[i];
                }

                if (notas[i] < menor)
                {
                    menor = notas[i];
                }
            }

            Console.WriteLine("Mayor:");
            for (int i = 0; i < 6; i++)
            {
                if (notas[i] == mayor)
                {
                    Console.WriteLine(nombres[i] + " - " + notas[i]);
                }
            }

            Console.WriteLine("Menor:");
            for (int i = 0; i < 6; i++)
            {
                if (notas[i] == menor)
                {
                    Console.WriteLine(nombres[i] + " - " + notas[i]);
                }
            }
        }

        static void Ordenar()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 6; j++)
                {
                    if (notas[i] < notas[j])
                    {
                        int aux = notas[i];
                        notas[i] = notas[j];
                        notas[j] = aux;

                        string auxN = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = auxN;
                    }
                }
            }
        }

        static void Aprobados()
        {
            int aprobados = 0;
            int desaprobados = 0;

            for (int i = 0; i < 6; i++)
            {
                if (notas[i] >= 6)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
            }

            Console.WriteLine("Aprobados: " + aprobados);
            Console.WriteLine("Desaprobados: " + desaprobados);
        }

        static void Mostrar()
        {
            Console.WriteLine("Lista ordenada:");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(nombres[i] + " - " + notas[i]);
            }
        }

        static void Main(string[] args)
        {
            Cargar();
            MayorMenor();
            Ordenar();
            Mostrar();
            Aprobados();
            Console.ReadKey();
        }
    }
}
