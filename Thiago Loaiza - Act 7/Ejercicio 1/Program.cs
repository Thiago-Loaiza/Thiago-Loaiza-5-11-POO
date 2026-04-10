using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class InfoVector
    {
        /*
           1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
              El valor acumulado de todos los elementos del vector.
              El valor acumulado de los elementos del vector que sean mayores a 36.
              Cantidad de valores mayores a 50.
        */
        private int[] Vec;
        public void IngresoNum()
        {
            Vec = new int[8];
            Console.WriteLine("Ingrese 8 valores del vector");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Ingrese el valor de vector");
                string linea;
                linea = Console.ReadLine();
                Vec[i] = int.Parse(linea);
            }
        }

        public void ValAcum()
        {
            int suma = 0;
            for (int i = 0;i < 8; i++)
            {
                suma = suma + Vec[i];
            }
            Console.WriteLine("El valor acumulado de los elementos es : " + suma);
        }

        public void ValAcum36()
        {
            int suma36 = 0;
            for (int i = 0; i < 8; i++)
            {
                if (Vec[i] > 36)
                {
                    suma36 = suma36 + Vec[i];
                }
            }
            Console.WriteLine("El valor acumulado de los elementos mayores a 36 es : " + suma36);
        }

        public void ValMay50()
        {
            int contmay = 0;
            for (int i = 0; i < 8; i++)
            {
                if (Vec[i] > 50)
                {
                    contmay++;
                }
            }
            Console.WriteLine("El valor mayores a 50 : " + contmay);
        }

        static void Main(string[] args)
        {
            InfoVector iv = new InfoVector();
            iv.IngresoNum();
            iv.ValAcum();
            iv.ValAcum36();
            iv.ValMay50();
            Console.ReadKey();
        }
    }
}
