using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /*
     1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
        dato las temperaturas medias mensuales de dichos paises.
        Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
        mensuales.
        Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
        memoria.
            a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
            b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las
            mismas.
            c. Calcular la temperatura media trimestral de cada país.
            d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
            e. Imprimir el nombre del país con la temperatura media trimestral mayor.
     */
    internal class TemperaturasPaises
    {
        private string[] paises;
        private int[,] temperaturas;
        private int[] temptrimestral;
        public void Carga()
        {
            paises = new string[4];
            temperaturas = new int [4, 3];

            for (int f = 0; f < paises.Length; f++) { 

                Console.WriteLine("Ingrese el nombre del pais");
                paises[f] = Console.ReadLine();

                for(int c = 0; c < temperaturas.GetLength(1); c++)
                {
                    Console.WriteLine("La temperatura del mes numero " + (c+1) + " de " + paises[f]);
                    string linea;
                    linea = Console.ReadLine();
                    temperaturas[f,c] =  int.Parse(linea);
                }

            }

        }

        public void Imprimir()
        {
            for (int f = 0; f < paises.Length; f++)
            {
                Console.WriteLine("Las temperaturas medias mensuales del pais " + paises[f] + " son :");
                for (int c = 0;c < temperaturas.GetLength(1); c++)
                {
                    Console.WriteLine(" - " + temperaturas[f, c]);
                }
            }
        }

        public void MediaTrim()
        {
            temptrimestral = new int[4];
            for (int f = 0;f < temperaturas.GetLength(0); f++)
            {
                int total=0;
                for (int c = 0;c < temperaturas.GetLength(1); c++)
                {
                    total = total + temperaturas[f,c];
                }
                temptrimestral[f] = total;
            }
        }

        public void ImprimirTrims()
        {
            for (int f = 0; f < paises.Length; f++)
            {
                    Console.WriteLine("Las temperatura media trimestral del pais " + paises[f] + "es :");
                    Console.WriteLine(temptrimestral[f]);
            }
        }

        public void MayorTempTrim()
        {
            int mayor = temptrimestral[0];
            string nombre = paises[0];
            for (int f = 0; f < paises.Length; f++)
            {
                if (temptrimestral[f] > mayor)
                {
                    mayor = temptrimestral[f];
                    nombre = paises[f];
                }
            }
            Console.WriteLine("El pais con mayor temperatura trimestral es : " + nombre + ", con una temperatura de : " + mayor);
        }

        static void Main(string[] args)
        {
            TemperaturasPaises tp = new TemperaturasPaises();

            tp.Carga();
            tp.Imprimir();
            tp.MediaTrim();
            tp.ImprimirTrims();
            tp.MayorTempTrim();
            Console.ReadKey();
        }
    }
}
