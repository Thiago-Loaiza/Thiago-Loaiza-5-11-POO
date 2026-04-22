using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    /*
     2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
        realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
        vectores paralelos, ordenar los datos de mayor a menor según las ventas,
        imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
        el que menos vendió de los 5 empleados.
     */
    internal class Program
    {
        static string[] nombres;
        static int[] ventas;

        static void Cargar()
        {
            nombres = new string[5];
            ventas = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ventas: ");
                ventas[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Ordenar()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (ventas[i] < ventas[j])
                    {
                        int auxV = ventas[i];
                        ventas[i] = ventas[j];
                        ventas[j] = auxV;

                        string auxN = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = auxN;
                    }
                }
            }
        }

        static void Mostrar()
        {
            Console.WriteLine("Lista ordenada: ");

            for (int i = 0; i < 5; i++)
            {
            Console.WriteLine(nombres[i] + " - " + ventas[i]);
            }

            Console.WriteLine("Menor venta:");
            Console.WriteLine(nombres[4] + " - " + ventas[4]);
        }

        static void Main(string[] args)
        {
            Cargar();
            Ordenar();
            Mostrar();
            Console.ReadKey();
        }
    }
}