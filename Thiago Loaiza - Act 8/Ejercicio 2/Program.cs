using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    /*
     2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
        algoritmo de ordenamiento alfabético.
     */
    internal class Paises
    {
        private string[] paises;

        public void Cargar()
        {
            paises = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre del pais:");
                paises[i] = Console.ReadLine();
            }
        }

        public void Ordenar()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (paises[i].CompareTo(paises[j]) > 0)
                    {
                        string aux = paises[i];
                        paises[i] = paises[j];
                        paises[j] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Paises ordenados:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(paises[i]);
            }
        }

        static void Main(string[] args)
        {
            Paises p = new Paises();

            p.Cargar();
            p.Ordenar();
            p.Imprimir();
            Console.ReadKey();
        }
    }
}