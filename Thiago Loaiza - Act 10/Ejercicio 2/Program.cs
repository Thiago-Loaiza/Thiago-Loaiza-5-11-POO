using System;

namespace Ejercicio_2
{
    internal class MatrizPersonalizada
    {
        private int[,] matriz;
        /*
         2- Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
            primer fila con la segunda. Imprimir luego la matriz.
         */
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

        public void IntercambioFila()
        {
            int columnas = matriz.GetLength(1);

            for (int c = 0; c < columnas; c++)
            {
                int aux = matriz[0, c];
                matriz[0, c] = matriz[1, c];
                matriz[1, c] = aux;
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            MatrizPersonalizada mp = new MatrizPersonalizada();

            mp.Carga();
            mp.IntercambioFila();
            mp.Imprimir();

            Console.ReadKey();
        }
    }
}