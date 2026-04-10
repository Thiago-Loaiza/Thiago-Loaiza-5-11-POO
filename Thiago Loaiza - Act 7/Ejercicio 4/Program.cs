using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class IdentificadorVectorde10
    {
        /*
         Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
         ordenado de menor a mayor y de mayor a menor.
         */
        private int[] Vec;
        public void IngresoVector()
        {
            Vec = new int[11];
            Console.WriteLine("Ingrese 10 valores del vector de menor a mayor o mayor o menor");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el valor de vector");
                string linea;
                linea = Console.ReadLine();
                Vec[i] = int.Parse(linea);
            }
        }

        public void MenorAMayor()
        {
            string verf1 = "";
            for (int i = 0; i < 10; i++)
            {
                if (Vec[i] < Vec[i+1])
                {
                    verf1 = "Es de menor a mayor";
                }
                else
                {
                    i = 10;
                    verf1 = "No es de mayor a menor";
                }
            }
            Console.WriteLine(verf1);
        }

        public void MayorAMenor()
        {
            string verf2 = "";
            for (int i = 0; i < 10; i++)
            {
                if (Vec[i] > Vec[i + 1])
                {
                    verf2 = "Es de mayor a menor";
                }
                else
                {
                    i = 10;
                    verf2 = "No es de mayor a mayor";
                }
            }
            Console.WriteLine(verf2);
        }

        static void Main(string[] args)
        {
            IdentificadorVectorde10 iv = new IdentificadorVectorde10();

            iv.IngresoVector();
            iv.MenorAMayor();
            iv.MayorAMenor();
            Console.ReadKey();
        }
    }
}
