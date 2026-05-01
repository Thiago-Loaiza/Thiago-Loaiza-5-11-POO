using System;

namespace Ejercicio_3
{
    /*
     3- Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
        cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
        etc.)
     */

    internal class MatrizVertices
    {
        private int[,] matriz;

        public void Carga()
        {
            int n;
            int m;
            string linea;

            Console.WriteLine("Ingrese cantidad de filas");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cantidad de columnas");
            m = int.Parse(Console.ReadLine());

            matriz = new int[n, m];

            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.WriteLine($"Valor para [{f},{c}]:");
                    linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void MostrarVertices()
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            Console.WriteLine("Vertices de la matriz:");

            Console.WriteLine("Arriba izquierda: " + matriz[0, 0]);
            Console.WriteLine("Arriba derecha: " + matriz[0, columnas - 1]);
            Console.WriteLine("Abajo izquierda: " + matriz[filas - 1, 0]);
            Console.WriteLine("Abajo derecha: " + matriz[filas - 1, columnas - 1]);
        }

        static void Main(string[] args)
        {
            MatrizVertices mv = new MatrizVertices();

            mv.Carga();
            mv.MostrarVertices();

            Console.ReadKey();
        }
    }
}