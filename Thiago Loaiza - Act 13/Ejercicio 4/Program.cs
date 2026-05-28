using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    /*
     4. Plantear una clase Alumno que tenga los atributos privados: nombre y un
        vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
        alumno y sus 4 calificaciones.

        Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
        Alumno.

        Agregar los siguientes métodos:
        a) Un método que imprima el nombre de cada alumno y su promedio.
        b) Un método que muestre el nombre del alumno con el promedio más
        alto.
        c) Un método que indique qué alumnos tienen al menos una nota
        desaprobada (nota menor a 6)
     */

    class Alumno
    {
        private string nombre;
        private int[] notas;

        public Alumno()
        {
            notas = new int[4];

            Console.WriteLine("Ingrese el nombre del alumno");
            nombre = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese la nota " + (i + 1));
                notas[i] = int.Parse(Console.ReadLine());
            }
        }

        public string RetornarNombre()
        {
            return nombre;
        }

        public double Promedio()
        {
            int suma = 0;

            for (int i = 0; i < 4; i++)
            {
                suma = suma + notas[i];
            }

            return suma / 4.0;
        }

        public bool Desaprobado()
        {
            for (int i = 0; i < 4; i++)
            {
                if (notas[i] < 6)
                {
                    return true;
                }
            }

            return false;
        }
    }

    internal class Curso
    {
        private Alumno[] alumnos;

        public Curso()
        {
            alumnos = new Alumno[3];

            for (int i = 0; i < 3; i++)
            {
                alumnos[i] = new Alumno();
            }
        }

        public void Promedios()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Alumno: " + alumnos[i].RetornarNombre());
                Console.WriteLine("Promedio: " + alumnos[i].Promedio());
            }
        }

        public void MejorPromedio()
        {
            double mayor = alumnos[0].Promedio();
            string nombre = alumnos[0].RetornarNombre();

            for (int i = 1; i < 3; i++)
            {
                if (alumnos[i].Promedio() > mayor)
                {
                    mayor = alumnos[i].Promedio();
                    nombre = alumnos[i].RetornarNombre();
                }
            }

            Console.WriteLine("El alumno con mejor promedio es: " + nombre);
        }

        public void Desaprobados()
        {
            Console.WriteLine("Alumnos con alguna nota desaprobada:");

            for (int i = 0; i < 3; i++)
            {
                if (alumnos[i].Desaprobado())
                {
                    Console.WriteLine(alumnos[i].RetornarNombre());
                }
            }
        }

        static void Main(string[] args)
        {
            Curso c = new Curso();

            c.Promedios();
            c.MejorPromedio();
            c.Desaprobados();

            Console.ReadKey();
        }
    }
}