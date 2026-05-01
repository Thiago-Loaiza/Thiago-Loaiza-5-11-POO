using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /*
        Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
        componentes por columna (es decir primero ingresar toda la primer
        columna, luego la segunda columna y así sucesivamente)
        Imprimir luego la matriz.
    */
    internal class CargaMatriz
    {
        private int[,] matriz;
        public void Carga()
        {
            matriz = new int[3, 5];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Indique el valor de la posicion actual de la matriz");
                    string linea;
                    linea = Console.ReadLine();
                    matriz[i, j] = int.Parse(linea);
                }

            }
        }

        public void Imprimir()
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            CargaMatriz cm = new CargaMatriz();

            cm.Carga();
            cm.Imprimir();
            Console.ReadKey();
        }
    }
}
