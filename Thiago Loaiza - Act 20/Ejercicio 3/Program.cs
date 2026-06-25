using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    /*
     Actividad 3: Estadísticas de visitas a zonas arqueológicas
        Problema:
        Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
        arqueológicas durante 4 semanas.
        Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los
        días. Luego:
         Calcular el total de visitas por zona y almacenarlo en un vector.
         Mostrar los datos en forma tabular.
         Agregar estos resultados a una lista llamada zonasVisitadas que contenga
        nombres de zonas y total de visitas.
         Determinar cuál fue la zona más visitada.
     */
    internal class Program
    {
        int[,] visitas = new int[3, 4];
        int[] totalZona = new int[3];

        List<Instituto> zonasVisitadas = new List<Instituto>();

        public void Seteo()
        {
            string[] nombres = { "AeroParque", "Obelico", "Cabildo" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("===================");
                Console.WriteLine("Zona: " + nombres[i]);

                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Ingrese las visitas de la semana " + (j + 1));
                    visitas[i, j] = int.Parse(Console.ReadLine());

                    totalZona[i] = totalZona[i] + visitas[i, j];
                }

                Instituto nuevo = new Instituto(nombres[i], totalZona[i]);

                zonasVisitadas.Add(nuevo);

                Console.WriteLine("Zona agregada correctamente.");
            }
        }

        public void Impresion()
        {
            Console.WriteLine();
            Console.WriteLine("TABLA DE VISITAS");
            Console.WriteLine("===========================");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(zonasVisitadas[i].NombreZona);

                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(visitas[i, j]);
                }

                Console.WriteLine();
            }
        }

        public void Totales()
        {
            Console.WriteLine();
            Console.WriteLine("TOTAL DE VISITAS POR ZONA");

            foreach (Instituto i in zonasVisitadas)
            {
                Console.WriteLine(i.NombreZona + ": " + i.TotalVisitas);
            }
        }

        public void Mayor()
        {
            int mayor = 0;
            string nombre = "";

            foreach (Instituto i in zonasVisitadas)
            {
                if (i.TotalVisitas > mayor)
                {
                    mayor = i.TotalVisitas;
                    nombre = i.NombreZona;
                }
            }

            Console.WriteLine();
            Console.WriteLine("La zona más visitada fue: " + nombre);
            Console.WriteLine("Con un total de " + mayor + " visitas.");
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            p.Seteo();
            p.Impresion();
            p.Totales();
            p.Mayor();

            Console.ReadKey();
        }
    }
}