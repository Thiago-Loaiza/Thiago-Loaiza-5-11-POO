using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    /*
     3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
        (el orden lo pueden elegir ustedes).
     */
    internal class VectorEnteros
    {
        private int[] vec;
        private int n;

        public void Cargar()
        {
            Console.WriteLine("Ingrese cantidad de elementos:");
            n = int.Parse(Console.ReadLine());

            vec = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese numero:");
                vec[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Ordenar()
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (vec[i] > vec[j])
                    {
                        int aux = vec[i];
                        vec[i] = vec[j];
                        vec[j] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Vector ordenado:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vec[i]);
            }
        }

        static void Main(string[] args)
        {
            VectorEnteros v = new VectorEnteros();

            v.Cargar();
            v.Ordenar();
            v.Imprimir();

            Console.ReadKey();
        }
    }
}