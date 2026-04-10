using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class DosVectores
    {
        /*
             2. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
                elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
                tercer vector del mismo tamaño. Sumar componente a componente.
        */
        private int[] Vec1;
        private int[] Vec2;
        private int[] VecSuma;

        public void Cargar2vec()
        {
            Vec1 = new int[4];
            Vec2 = new int[4];

            Console.WriteLine("Ingrese los 4 valores de Vector 1");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el valor de vector");
                string linea;
                linea = Console.ReadLine();
                Vec1[i] = int.Parse(linea);
            }

            Console.WriteLine("Ingrese los 4 valores de Vector 2");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el valor de vector");
                string linea;
                linea = Console.ReadLine();
                Vec2[i] = int.Parse(linea);
            }
        }

        public void SumaVectores()
        {
            VecSuma = new int[4];
            int valor = 0;
            for (int i = 0; i < 4; i++)
            {
                valor = Vec1[i] + Vec2[i];
                VecSuma[i] = valor;
            }

            Console.WriteLine("El vector de la suma de los dos vectores es : ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(VecSuma[i]);
                Console.Write(" - ");
            }
        }

        static void Main(string[] args)
        {
            DosVectores dv = new DosVectores();
            dv.Cargar2vec();
            dv.SumaVectores();
            Console.ReadKey();
        }
    }
}
